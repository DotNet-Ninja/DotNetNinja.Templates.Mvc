using DotNetNinja.Templates.Mvc.Constants;

namespace DotNetNinja.Templates.Mvc.Configuration;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseStrictTransportSecurity(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseHsts();
        }

        return app;
    }

    public static IApplicationBuilder UseErrorHandler(
        this IApplicationBuilder app, 
        IWebHostEnvironment env,
        string errorPath = WellKnownEndpoint.ErrorHandler)
    {
        if (!env.IsDevelopment())
        {
            app.UseExceptionHandler(errorPath);
        }

        return app;
    }

    public static IApplicationBuilder UseApplicationEndpoints(this IApplicationBuilder app)
    {
        return app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}