using DotNetNinja.Templates.Mvc.Services;

namespace DotNetNinja.Templates.Mvc.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ITimeProvider, DefaultTimeProvider>();

        return services;
    }
}