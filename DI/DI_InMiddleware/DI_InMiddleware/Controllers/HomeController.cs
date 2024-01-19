using DI_InMiddleware.Interface;
using DI_InMiddleware.Models;
using DI_InMiddleware.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace DI_InMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<INotificationService> _notificationService;
        private readonly ILogger<HomeController> _logger;
        //private readonly INotificationService _notificationService;
        private readonly IuploadServer _uploadToServer;
        private readonly IShareService _shareService;

        public HomeController(ILogger<HomeController> logger, IEnumerable<INotificationService> notificationService
           /* , INotificationService notificationService*/
           , IuploadServer iuploadServer, IShareService shareService)
        {
            _logger = logger;
            _notificationService = notificationService;
            _uploadToServer = iuploadServer;
            _shareService = shareService;
        }

        public IActionResult Upload()
        {
            _uploadToServer.Upload(null);
            return Ok(true);
        }
        public IActionResult Share()
        {
            return Ok(_shareService.Execute());
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
