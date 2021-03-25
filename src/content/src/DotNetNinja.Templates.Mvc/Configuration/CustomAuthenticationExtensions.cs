using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace DotNetNinja.Templates.Mvc.Configuration
{
    public static class CustomAuthenticationExtensions
    {
        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services, AuthenticationSettings settings)
        {
            return services
                .AddAuthentication(options => {
                    options.DefaultAuthenticateScheme = settings.DefaultAuthenticationScheme;
                    options.DefaultSignInScheme = settings.DefaultSignInScheme;
                    options.DefaultChallengeScheme = settings.DefaultChallengeScheme;
                })
                .AddCookie()
                .AddOpenIdConnect("Auth0", options => {
                    options.Authority = $"https://{settings.Authority}";
                    options.ClientId = settings.ClientId;
                    options.ClientSecret = settings.ClientSecret;
                    options.ResponseType = settings.ResponseType;
                    options.Scope.Clear();
                    options.Scope.Add(settings.ScopesValue);
                    options.CallbackPath = new PathString(settings.CallbackPath);
                    options.ClaimsIssuer = settings.ClaimsIssuer;
                    options.MapInboundClaims = true;
                    options.SaveTokens = settings.SaveTokens;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = settings.NameClaimType,
                        RoleClaimType = settings.RoleClaimType
                    };
                    options.Events = new OpenIdConnectEvents
                    {
                        OnRedirectToIdentityProviderForSignOut = (context) =>
                        {
                            var logoutUri = $"https://{settings.Authority}/v2/logout?client_id={settings.ClientId}";
                            var postLogoutUri = context.Properties.RedirectUri;
                            if (!string.IsNullOrEmpty(postLogoutUri))
                            {
                                if (postLogoutUri.StartsWith("/"))
                                {
                                    var request = context.Request;
                                    postLogoutUri = $"{request.Scheme}://{request.Host}{request.PathBase}{postLogoutUri}";
                                }
                                logoutUri += $"&returnTo={ Uri.EscapeDataString(postLogoutUri)}";
                            }
                            context.Response.Redirect(logoutUri);
                            context.HandleResponse();
                            return Task.CompletedTask;
                        }
                    };
                }).Services;
        }
    }
}