using DotNetNinja.Templates.Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNinja.Templates.Mvc.Controllers;

public abstract class MvcController<TController>: Controller where TController: Controller
{
    private readonly IMvcContext<TController> _context;

    protected MvcController(IMvcContext<TController> context)
    {
        _context = context;
    }

    protected ILogger Logger => _context.Logger;
    protected ITimeProvider Time => _context.Time;
    protected IWebHostEnvironment Host => _context.Host;
}