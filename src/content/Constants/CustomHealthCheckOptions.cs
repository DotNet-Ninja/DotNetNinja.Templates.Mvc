using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DotNetNinja.Templates.Mvc.Constants;

public static class CustomHealthCheckOptions
{

    public static readonly HealthCheckOptions Default = new()
    {
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
        ResultStatusCodes =
        {
            [HealthStatus.Healthy] = HttpStatus.Ok,
            [HealthStatus.Degraded] = HttpStatus.Ok,
            [HealthStatus.Unhealthy] = HttpStatus.ServiceUnavailable
        },
        AllowCachingResponses = false
    };

    public static HealthCheckOptions TaggedDefaultOptions(string tag)
    {
        return TaggedDefaultOptions(new[] { tag });
    }

    public static HealthCheckOptions TaggedDefaultOptions(IEnumerable<string> tags)
    {
        return new HealthCheckOptions
        {
            Predicate = (item) => item.Tags.Intersect(tags).Any(),
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
            ResultStatusCodes =
            {
                [HealthStatus.Healthy] = HttpStatus.Ok,
                [HealthStatus.Degraded] = HttpStatus.Ok,
                [HealthStatus.Unhealthy] = HttpStatus.ServiceUnavailable
            },
            AllowCachingResponses = false
        };
    }

    public static HealthCheckOptions LivelinessOptions => new()
    {
        Predicate = _ => false,
        ResultStatusCodes =
        {
            [HealthStatus.Healthy] = HttpStatus.Ok,
            [HealthStatus.Degraded] = HttpStatus.Ok,
            [HealthStatus.Unhealthy] = HttpStatus.ServiceUnavailable
        },
        AllowCachingResponses = false
    };
}