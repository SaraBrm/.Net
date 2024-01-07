using Microsoft.AspNetCore.Mvc;

namespace Routing.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        [Route("[area]/[controller]/[action]",Name ="AdminRoute")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
