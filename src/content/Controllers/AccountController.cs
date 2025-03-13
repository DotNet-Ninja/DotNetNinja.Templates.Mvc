using Auth0.AspNetCore.Authentication;
using DotNetNinja.Templates.Mvc.Models;
using DotNetNinja.Templates.Mvc.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNinja.Templates.Mvc.Controllers;
public class AccountController : MvcController<AccountController>
{
    private readonly ISignInService _signInService;

    public AccountController(IMvcContext<AccountController> context, ISignInService signInService) : base(context)
    {
        _signInService = signInService;
    }

    [HttpGet, Authorize]
    public IActionResult Index()
    {
        var model = new UserAccountModel(User);
        return View(model);
    }

    [HttpGet]
    public async Task LogIn(string returnUrl = "/")
    {
        var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
            .WithRedirectUri(returnUrl)
            .Build();

        await _signInService.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
    }

    [HttpGet, Authorize]
    public IActionResult Diagnostics()
    {
        if (!Host.IsDevelopment())
        {
            return NotFound();
        }
        return View(User.Claims);
    }

    [HttpGet, Authorize]
    public async Task LogOut()
    {
        var authenticationProperties = new LogoutAuthenticationPropertiesBuilder()
            .WithRedirectUri("/")
            .Build();

        await _signInService.SignOutAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
        await _signInService.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}
