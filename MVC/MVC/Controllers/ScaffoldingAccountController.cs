using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models.Repositories;

namespace MVC.Controllers
{
    public class ScaffoldingAccountController : Controller
    {
        private readonly AccountRepository _accountRepository;
        public ScaffoldingAccountController()
        {
                _accountRepository = new AccountRepository();
        }
        // GET: ScaffoldingAccountController
        public ActionResult Index()
        {
            return View(_accountRepository.Get());
        }

        // GET: ScaffoldingAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View(_accountRepository.Find());
        }

        // GET: ScaffoldingAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScaffoldingAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ScaffoldingAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_accountRepository.Find());
        }

        // POST: ScaffoldingAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ScaffoldingAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_accountRepository.Find());
        }

        // POST: ScaffoldingAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
