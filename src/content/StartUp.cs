using DotNetNinja.Templates.Mvc.Configuration;

namespace DotNetNinja.Templates.Mvc;

public class StartUp(IConfiguration configuration)
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDotNetNinjaMvcCore(configuration, out var settings)
            .AddApplicationHealthChecks(settings)
            .AddControllersWithViews()
            .WithContext();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDotNetNinjaMvc(env);
    }
}