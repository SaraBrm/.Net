using Microsoft.AspNetCore.Mvc;
using MVCViewComponent.Models.Repositories;

namespace MVCViewComponent.ViewComponents
{
    public class UserDetail : ViewComponent
    {
        private readonly UserRepository _userRepository;

        public UserDetail()
        {
            _userRepository = new UserRepository();
        }
        public IViewComponentResult Invoke(long Id)
        {

            var user = _userRepository.Find(Id);
            return View(viewName: "UserDetail", user);
        }


        //public Task<IViewComponentResult> InvokeAsync(long Id)
        //{

        //    var user = _userRepository.Find(Id);
        //    return View(viewName: "UserDetail",user);
        //}
    }
}
