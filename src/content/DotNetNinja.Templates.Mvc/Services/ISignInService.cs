using Microsoft.AspNetCore.Authentication;

namespace DotNetNinja.Templates.Mvc.Services;

public interface ISignInService
{
    Task ChallengeAsync(string scheme, AuthenticationProperties properties);
    Task SignOutAsync(string scheme, AuthenticationProperties properties);
    Task SignOutAsync(string scheme);
}