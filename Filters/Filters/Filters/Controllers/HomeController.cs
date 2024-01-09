using Filters.Models;
using Filters.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[CacheResourceFilter]
        [TypeFilter(typeof(CacheResourceFilter))]
        public IActionResult Index()
        {
            return Content("Index", "This content was generated at " + DateTime.Now);
        }


        [AuthorizeActionFilter("User")]
        public IActionResult List()
        {
            return View();
        }

        [AuthorizeActionFilter("Admin")]
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
