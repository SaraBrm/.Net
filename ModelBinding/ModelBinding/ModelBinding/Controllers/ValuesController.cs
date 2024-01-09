using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Edit(UserInfoDto user)
        {
            user.UserId = 20;
            EditUserService editUser = new EditUserService();
            editUser.Execute(user);
            //------
            return Ok();
        }
    }
}
