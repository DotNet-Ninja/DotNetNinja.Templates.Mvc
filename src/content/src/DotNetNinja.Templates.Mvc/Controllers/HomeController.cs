﻿using ChaosMonkey.Guards;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetNinja.Templates.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = Guard.IsNotNull(logger, nameof(logger));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
