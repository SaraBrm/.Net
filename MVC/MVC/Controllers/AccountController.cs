using Microsoft.AspNetCore.Mvc;
using MVC.Models.Entities;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(Users users)
        {
            if (ModelState.IsValid)
            {
                //ok
            }
            else
            {
                //not validate
            }
            return View();
        }
    }
}
