using Microsoft.AspNetCore.Mvc;

namespace DotNetNinja.Templates.Mvc.Controllers
{
    public abstract class MvcController : Controller
    {
        protected ILogger Logger { get; }

        protected MvcController(ILogger logger)
        {
            Logger = logger;
        }
    }
}
