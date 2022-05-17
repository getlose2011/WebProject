using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProject.Models;
using WebProject.Service;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookService _service;
        private readonly ActService _actService;

        public HomeController(ILogger<HomeController> logger, BookService service,ActService actService)
        {
            _logger = logger;
            _service = service;
            _actService = actService;
        }

        public async Task<IActionResult> Index()
        {
            //https://www.youtube.com/watch?v=Ep0sFH-2nMQ
            var data = await _service.Get();
            var data1 = _actService.get();
            var data2 = _actService.get2();
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
}