using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using MVC.Models.ViewModels;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["SiteName"] = "frazbook";

            ViewData["Product"] = new ProductViewModel
            {
                Id = 1020,
                Name = "Asp.Net Core 5.0",
                Price = 890000,
            };

            ViewBag.name = "sra";


            TempData["age"] = 23;
            return View();
        }

        public IActionResult Index2()
        {
            var age = TempData["age"];
            TempData.Keep();
            string name = ViewBag.name;
            return View();
        }

        public IActionResult Index3()
        {
            var age = TempData["age"];

            return View();
        }

        public IActionResult SearchKey(string searchKey)
        {
            //string searchKey = HttpContext.Request.Query["searchKey"].ToString();
            return View();
        }

        public IActionResult CheckAuthorize([FromHeader] string AuthorizeKey)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(RegisterUserViewModel model)
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Register([FromBody] RegisterUserViewModel model)
        //{
        //    return View();
        //}

        public IActionResult Contact()
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
