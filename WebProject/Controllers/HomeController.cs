using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Security.Claims;
using System.Text;
using WebProject.Service;

namespace WebProject.Controllers
{
    [Authorize(Roles = "Administrator,Administrator_1")]
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

        [AllowAnonymous]
        public string Privacy()
        {
            //可以使用 HttpContext.User.Identity.IsAuthenticated 來判斷用戶是否登入
            //但由於此Action已經加上[Authorize]，表示會執行此Action內容的一定都是登入者，所以不必再脫褲子放屁多寫判斷XD
            #pragma warning disable CS8602 // 可能 null 參考的取值 (dereference)。
            var login = HttpContext.User.Identity.IsAuthenticated;
            #pragma warning restore CS8602 // 可能 null 參考的取值 (dereference)。
            return login?"log in":"logout";
        }

        /// <summary>
        /// 500 error
        /// </summary>
        /// <returns></returns>
        public string error500()
        {
            int i = 0;
            i = 1 / i;  // cause exception
            return "";
        }

        public string claimname()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<ul>");

            foreach (Claim claim in HttpContext.User.Claims)
            {
                sb.AppendLine($@"<li> claim.Type:{claim.Type} , claim.Value:{ claim.Value}</li>");
            }
            sb.AppendLine("</ul>");

            return sb.ToString();
        }

        /// <summary>
        /// 404頁面
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult notfound()
        {            
            return Redirect("~/404.html"); //或http開頭的絕對URL
        }

        /// <summary>
        /// 500頁面
        /// </summary>
        /// <returns></returns>

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return Redirect("~/500.html"); //或http開頭的絕對URL
        }
    }
}