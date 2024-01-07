using Microsoft.AspNetCore.Mvc;

namespace RputingApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [Route("~/Products", Name = "productList", Order = -2)]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}


