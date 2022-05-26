using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    public class CsrfController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string first_name)
        {
            return View();
        }

        [HttpGet]
        public IActionResult AjaxCreate()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult AjaxCreate(string date)
        {
            return PartialView("_IndexDataList");
        }

    }
}
