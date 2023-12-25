using Microsoft.AspNetCore.Mvc;
using MVC.Models.Entities;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            Users users = new Users()
            {
                Email = "sb@gmail,.com",
                Name = "sr",
                LastName = "Brm"
            };
            return View(users);
        }

        public IActionResult Profile()
        {
            Users users = new Users()
            {
                Id = 1,
                Email = "sb@gmail,.com",
                Name = "sr",
                LastName = "Brm",
                Description = " this is a text for test",
                IsActive = true,
            };
            return View(users);
        }
    }
}
