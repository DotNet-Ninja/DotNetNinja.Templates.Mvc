using System.Collections.Generic;
using DotNetNinja.AutoBoundConfiguration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace DotNetNinja.Templates.Mvc.Configuration
{
    [AutoBind("Authentication")]
    public class AuthenticationSettings
    {
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string NameClaimType { get; set; }
        public string RoleClaimType { get; set; }
        public List<string> Scopes { get; set; } = new List<string> {"openid"};

        public string ClaimsIssuer { get; set; }
        public string CallbackPath { get; set; } = "/signin-oidc";
        public string ResponseType { get; set; } = OpenIdConnectResponseType.Code;

        public string DefaultAuthenticationScheme { get; set; } = CookieAuthenticationDefaults.AuthenticationScheme;
        public string DefaultSignInScheme { get; set; } = CookieAuthenticationDefaults.AuthenticationScheme;
        public string DefaultChallengeScheme { get; set; } = CookieAuthenticationDefaults.AuthenticationScheme;

        public bool SaveTokens { get; set; } = true;
        
        public string ScopesValue => string.Join(' ', Scopes ?? new List<string>()).Trim();
    }
}