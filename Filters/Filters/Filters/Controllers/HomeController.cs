using Filters.Models;
using Filters.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Filters.Controllers
{
    [ShowMessage("Controller")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [TypeFilter(typeof(CustomExceptionFilter))]
        public IActionResult Error()
        {
            throw new NotImplementedException();
        }

        [ValidateModelAttribute]
        [HttpPost]
        public IActionResult ProductEdit([FromForm] ProductViewmodel product)
        {
            return View();
        }

        //[CacheResourceFilter]
        //[TypeFilter(typeof(CacheResourceFilter))]
        //[AddHeaderFilter]
        //[ShowMessage("Action")]
        //[TypeFilter(typeof(ShowMessage))]
        [ServiceFilter(typeof(AddHeaderFilter))]
        public IActionResult Index()
        {
            return View("Index", "This content was generated at " + DateTime.Now);
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

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
