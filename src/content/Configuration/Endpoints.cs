using DotNetNinja.Templates.Mvc.Constants;

namespace DotNetNinja.Templates.Mvc.Configuration;

public static class Endpoints
{
    public static void Build(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapControllerRoute(
            name: "Default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    }
}