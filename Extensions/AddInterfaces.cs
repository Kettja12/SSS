using System.Runtime.CompilerServices;

namespace SSS.Extensions;

public static partial class Extensions
{
    public static void AddInterfaces(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");
    }
}
