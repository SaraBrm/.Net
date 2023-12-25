using Microsoft.AspNetCore.Mvc;
using MVC.Models.Repositories;

namespace MVC.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsRepository _newsRepository;

        public NewsController()
        {
            _newsRepository = new NewsRepository();
        }
        public JsonResult Index()
        {
            return Json(_newsRepository.GetList());
        }
    }
}
