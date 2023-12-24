using Logging.Models;
using Logging.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Logging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger("Home");

        }

        public IActionResult Index()
        {
            //_logger.Log(LogLevel.Information, "Request Start");
            _logger.LogInformation("Request Start......");

            if (1 == 1)
            {
                _logger.LogWarning("File Not Found!");
            }

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                _logger.LogError(LogEvent.SpecificErrorOccurred, ex, "error ......");
            }

            _logger.LogError(LogEvent.SomeErrorOccurred, " error ......  test");

            int a = 10;
            int b = 20;
            int c = a + b;
            _logger.LogDebug("The sum of two numbers");
             
            _logger.LogTrace($" c = {c}");

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "can not connect database");
            }
            _logger.LogInformation("Request End......");

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
