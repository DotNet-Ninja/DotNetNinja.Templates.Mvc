using DotNetNinja.Templates.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNinja.Templates.Mvc.ViewComponents;

public class NavigationViewComponent:ViewComponent
{
    private readonly Navigation _menu;

    public NavigationViewComponent(Navigation menu)
    {
        _menu = menu;
    }

    public IViewComponentResult Invoke()
    {
        return View(_menu);
    }
}