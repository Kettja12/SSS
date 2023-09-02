using System.Runtime.CompilerServices;

namespace SSS.Extensions
{
    public static partial class Extensions
    {
        public static void AddIntefrace(this WebApplicationBuilder builder)
        {
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

        }
    }
}
