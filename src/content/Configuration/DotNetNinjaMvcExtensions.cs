using Auth0.AspNetCore.Authentication;
using DotNetNinja.AutoBoundConfiguration;
using DotNetNinja.Templates.Mvc.Constants;
using DotNetNinja.Templates.Mvc.Controllers;
using DotNetNinja.Templates.Mvc.Services;

namespace DotNetNinja.Templates.Mvc.Configuration;

public static class DotNetNinjaMvcExtensions
{
    public static IServiceCollection AddDotNetNinjaMvcCore(this IServiceCollection services, IConfiguration configuration,
        out IAutoBoundConfigurationProvider provider)
    {
        return services.AddAutoBoundConfigurations(configuration, out provider)
            .AddApplicationServices()
            .AddApplicationHealthChecks(provider)
#if (Authentication)
            .AddAuthentication(provider)
#endif
            ;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services
            .AddHttpContextAccessor()
            .AddTransient<ISignInService, SignInService>()
            .AddSingleton<ITimeProvider, SystemTimeProvider>();
    }

    public static IServiceCollection AddAutoBoundConfigurations
        (this IServiceCollection services, IConfiguration configuration, out IAutoBoundConfigurationProvider provider)
    {
        provider = services.AddAutoBoundConfigurations(configuration).FromAssemblyOf<StartUp>().Provider;
        return services;
    }

    public static IServiceCollection AddApplicationHealthChecks(this IServiceCollection services, IAutoBoundConfigurationProvider provider)
    {
        var checks = services.AddHealthChecks();
        return services;
    }

    public static IServiceCollection AddAuthentication(this IServiceCollection services, IAutoBoundConfigurationProvider provider)
    {
        var settings = provider.Get<AuthenticationSettings>();
        services.Configure<CookiePolicyOptions>(options =>
        {
            options.MinimumSameSitePolicy = SameSiteMode.None;
        });

        services.AddAuth0WebAppAuthentication(options =>
        {
            options.Domain = settings.Domain;
            options.ClientId = settings.ClientId;
        });

        return services;
    }

    public static IApplicationBuilder UseDotNetNinjaMvc(this IApplicationBuilder builder, IWebHostEnvironment environment)
    {
        return builder.UseStrictTransportSecurity(environment)
            .UseGlobalExceptionHandler(environment)
            .UseHttpsRedirection()
            .UseStaticFiles()
            .UseRouting()
#if (Authentication)
            .UseAuthentication()
#endif
            .UseAuthorization()
            .UseApplicationEndpoints();
    }

    public static IApplicationBuilder UseApplicationEndpoints(this IApplicationBuilder app)
    {
        return app.UseEndpoints(endpoints =>
        {
            endpoints.MapHealthChecks(WellKnownEndpoint.HealthChecks.Liveliness, CustomHealthCheckOptions.LivelinessOptions);
            endpoints.MapHealthChecks(WellKnownEndpoint.HealthChecks.Databases, CustomHealthCheckOptions.TaggedDefaultOptions("Database"));
            endpoints.MapHealthChecks(WellKnownEndpoint.HealthChecks.Readiness, CustomHealthCheckOptions.Default);
            Endpoints.Build(endpoints);
        });
    }

    public static IApplicationBuilder UseStrictTransportSecurity(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseHsts();
        }
        return app;
    }

    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            return app.UseDeveloperExceptionPage();
        }

        return app.UseExceptionHandler(WellKnownEndpoint.ErrorHandler);
    }

    public static IServiceCollection WithContext(this IMvcBuilder builder)
    {
        builder.Services
            .AddScoped(typeof(IMvcContext<>), typeof(MvcContext<>));
        return builder.Services;
    }
}