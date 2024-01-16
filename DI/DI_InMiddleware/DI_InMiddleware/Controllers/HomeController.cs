using DI_InMiddleware.Interface;
using DI_InMiddleware.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DI_InMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<INotificationService> _notificationService;
        private readonly ILogger<HomeController> _logger;
        //private readonly INotificationService _notificationService;

        public HomeController(ILogger<HomeController> logger, IEnumerable<INotificationService> notificationService
           /* , INotificationService notificationService*/)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            foreach (var item in _notificationService)
            {
                item.Send("hi.......", 85845);
            }
            //_notificationService.Send("hi.......", 85845);
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
