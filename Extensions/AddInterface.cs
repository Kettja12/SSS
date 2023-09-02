using Microsoft.EntityFrameworkCore;
using SSS.Repository;
using SSS.Services;
using System.Runtime.CompilerServices;

namespace SSS.Extensions
{
    public static partial class Extensions
    {
        public static void AddIntefrace(this WebApplicationBuilder builder)
        {
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddLocalization();
            builder.Services.AddScoped<StateContainer>();
            builder.Services.AddScoped<SSS.Repository.Repository>();
            var connectionstring = builder.Configuration.GetConnectionString("SSS");
            if (connectionstring == null) throw new Exception("No Connectionstring");
            builder.Services.AddDbContextFactory<SSSDatacontext>(opt =>
                opt.UseSqlServer(connectionstring));


        }
    }
}
