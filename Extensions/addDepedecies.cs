using BlazorPro.BlazorSize;
using Microsoft.EntityFrameworkCore;
using SSS.Repositories;
using SSS.Services;
using System.Runtime.CompilerServices;

namespace SSS.Extensions;

public static partial class Extensions
{
    public static void AddDepedencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddLocalization();
        builder.Services.AddScoped<StateContainer>();
        builder.Services.AddScoped<Repository>();
        var connectionstring = builder.Configuration.GetConnectionString("SSS");
        if (connectionstring == null) throw new Exception("No Connectionstring");
        builder.Services.AddDbContextFactory<SSSDatacontext>(opt =>
            opt.UseSqlServer(connectionstring));
        builder.Services.AddMediaQueryService();

        // Get the IDbContextFactory<SSSDatacontext>
        var factory = builder.Services
            .BuildServiceProvider()
            .GetRequiredService<IDbContextFactory<SSSDatacontext>>();
        Appsettings appsettings = new();
        var result =appsettings.Init(factory);
        builder.Services.AddSingleton(appsettings);

    }
}
public record Appsettings
{
    public string ApplicationName { get; private set; } = string.Empty;
    public string Init(IDbContextFactory<SSSDatacontext> factory)
    {
        try
        {
            var context = factory.CreateDbContext();
            var data = context.AppSettings.ToList();
            foreach (var item in data)
            {
                switch (item.Key)
                {
                    case "ApplicationName": ApplicationName = item.SValue; break;
                }
            }
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        return "";

    }
}
