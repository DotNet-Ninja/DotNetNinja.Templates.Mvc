using DotNetNinja.Templates.Mvc.Configuration;
using DotNetNinja.Templates.Mvc.Services;

namespace DotNetNinja.Templates.Mvc;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplicationServices()
                .AddControllersWithViews();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseStrictTransportSecurity(env)
            .UseErrorHandler(env)
            .UseHttpsRedirection()
            .UseStaticFiles()
            .UseRouting()
            .UseAuthorization()
            .UseApplicationEndpoints();
    }
}