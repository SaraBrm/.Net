using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int Id, string title)
        {
            return View(Id);
        }
    }
}
