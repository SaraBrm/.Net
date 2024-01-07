using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace Routing.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }


        public IActionResult Edit()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [HttpPost]
        public IActionResult Edit(string productName)
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
    }
}
