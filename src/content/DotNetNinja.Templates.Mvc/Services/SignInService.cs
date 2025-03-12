using Microsoft.AspNetCore.Authentication;

namespace DotNetNinja.Templates.Mvc.Services;

public class SignInService: ISignInService
{
    private readonly HttpContext _context;

    public SignInService(IHttpContextAccessor accessor)
    {
        _context = accessor?.HttpContext ?? throw new NullReferenceException("HttpContext Null");
    }

    public Task ChallengeAsync(string scheme, AuthenticationProperties properties)
    {
        return _context.ChallengeAsync(scheme, properties);
    }

    public Task SignOutAsync(string scheme, AuthenticationProperties properties)
    {
        return _context.SignOutAsync(scheme, properties);
    }

    public Task SignOutAsync(string scheme)
    {
        return _context.SignOutAsync(scheme);
    }
}