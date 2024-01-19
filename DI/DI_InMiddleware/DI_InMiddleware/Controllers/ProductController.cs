using DI_InMiddleware.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_InMiddleware.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepository Repository { get; }

        public ProductController(IProductRepository repository)
        {
            Repository = repository;
        }

        public IActionResult Index()
        {
            //var users = new List<user>()
            //{
            //     new user { Name="sara"}
            //};
            return View(Repository.GetProducts());
        }
    }

    public class user
    {
        public string Name { get; set; }
    }
}
