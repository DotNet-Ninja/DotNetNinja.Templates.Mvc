using Microsoft.AspNetCore.Mvc;

namespace DotNetNinja.Templates.Mvc.Controllers;

public class HomeController : MvcController
{
    public HomeController(ILogger<HomeController> logger):base(logger)
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}
