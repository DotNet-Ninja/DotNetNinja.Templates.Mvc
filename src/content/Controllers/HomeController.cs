using Microsoft.AspNetCore.Mvc;

namespace DotNetNinja.Templates.Mvc.Controllers;

public class HomeController : MvcController<HomeController>
{
    public HomeController(IMvcContext<HomeController> context) : base(context)
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}
