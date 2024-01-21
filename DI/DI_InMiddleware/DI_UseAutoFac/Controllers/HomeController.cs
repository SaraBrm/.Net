using DI_UseAutoFac.Models;
using DI_UseAutoFac.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DI_UseAutoFac.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMath _math;
        public HomeController(IMath math)
        {
            _math = math;
        }
        public IActionResult Index()
        {
            return Ok(_math.Execute(4, 2));
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
