using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index(int id ,[FromQuery(Name ="personName")]string FullName)
        //{
        //    return View();
        //}     

        //[HttpPost]
        //public IActionResult Edit(/*[Bind("LastName","Name","Token")]*/UserInfoDto user)
        //{
        //    user.UserId = 20;
        //    EditUserService editUser = new EditUserService();
        //    editUser.Execute(user);
        //    //edit----
        //    return View();
        //}

        //complex type ****************************************
        //public IActionResult Edit()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Edit([Bind(Prefix = "u")] Article article)
        //{
        //    return View();
        //}

        public IActionResult Edit([FromServices] IMyService myService)
        {
            myService.Test();
            return View();
        }

        [Consumes("application/json")]
        [HttpPost]
        public IActionResult Edit(string[] ch, Dictionary<int, string> dic,
            IFormCollection keyValues, IFormFile file, IFormFileCollection formFiles)
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public interface IMyService
    {
        void Test();
    }
    public class MyService : IMyService
    {
        public void Test()
        {
            throw new NotImplementedException();
        }
    }



    public class EditUserService
    {
        public void Execute(UserInfoDto user)
        {
            //Edit
        }
    }

}

