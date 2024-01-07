using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using Microsoft.Extensions.Logging;
using Routing.Models;
using System.Diagnostics;
using System.Security.Policy;
using System.Xml.Linq;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index(int id, string name)
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            //string url = Url.Action("Destination");
            //string url = Url.Action("Destination","Home",new { id=3,name="spring"});
            //string url = Url.RouteUrl("route1",new { id = 3,name = "spring"});
            //string url = Url.RouteUrl("route1", new { id = 3, name = "spring" }, protocol:Request.Scheme);
            string url = Url.RouteUrl("AdminRoute");
            return ControllerContext.MyDisplayRouteInfo("", $"Url: {url}");
        }

        //[HttpGet("MyHome/books/fa/destination")]
        [HttpGet("myhome/books/fa/destination/{id}/{name}", Name = "route1")]
        //[HttpGet("MyHome/books/fa/destination", Name = "route1")]
        public IActionResult Destination(int id, string name)
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult About()
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
