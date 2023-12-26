using Microsoft.AspNetCore.Mvc;
using MVCViewComponent.Models.Repositories;

namespace MVCViewComponent.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        public IActionResult Index()
        {
            return View(_userRepository.GetUserList());
        }

        public IActionResult Details(long Id)
        {
            ViewBag.Id = Id;
            return View(_userRepository.Find(Id));
        }

        public IActionResult UserDetailViewComponent(long Id)
        {
            return ViewComponent("UserDetail", new { Id = Id });
        }
    }
}
