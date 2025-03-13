namespace DotNetNinja.Templates.Mvc.Constants;

public static class WellKnownEndpoint
{
    public static readonly string ErrorHandler = "/Error/ServerError";
    public static readonly string ApplicationRoot = "~/";
    public static readonly string AbsoluteRoot = "/";
    public static readonly string AuthCallback = "/signin-oidc";
    public static readonly string SignIn = "/Account/LogIn";
    public static readonly string SignOut = "/Account/LogOut";
    public static readonly string SignOutRedirectUrl = ApplicationRoot;
    public static readonly string AccessDenied = "/Error/AccessDenied";

    public static class HealthChecks
    {
        public static readonly string Databases = "/healthz/databases";
        public static readonly string Liveliness = "/healthz/liveliness";
        public static readonly string Readiness = "/healthz";
    }
}