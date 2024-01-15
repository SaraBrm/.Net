using DI_UseBuiltInIocContainer.Interfaces;
using DI_UseBuiltInIocContainer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DI_UseBuiltInIocContainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISendMessage _sendMessage;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;
        public HomeController(ILogger<HomeController> logger
         , ISendMessage sendMessage
            , IScopedService scopedService
            , ITransientService transientService
            , ISingletonService singletonService)
        {
            _logger = logger;
            _sendMessage = sendMessage;
            _scopedService = scopedService;
            _transientService = transientService;
            _singletonService = singletonService;

        }

        public IActionResult Index()
        {
            _scopedService.test();
            _transientService.test();
            _singletonService.test();
            _sendMessage.Send("Hi IOC ");
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
