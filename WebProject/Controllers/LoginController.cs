using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;

namespace WebProject.Controllers
{

    [Authorize]
    public class LoginController : Controller
    {

        [AllowAnonymous]
        public string nologin()
        {
            return "no login";
        }

        [AllowAnonymous]
        public async Task<IActionResult> login(string ReturnUrl)
        {
            //未登入者想進入必須登入的頁面，他會被自動導頁至/login/login，網址後面也會自動帶上名為ReturnUrl(原始要求網址)的QueryString

            //建立 Claim，也就是要寫到 Cookie 的內容
            var claims = new List<Claim>() {
                new Claim("UserId", "11"),
                new Claim("Account", "tester"),
                new Claim(ClaimTypes.Name, "tester tester"),
                new Claim(ClaimTypes.Role, "Administrator")
            };

            await setClaimsPrincipal(claims);

            ///加上 Url.IsLocalUrl 防止Open Redirect漏洞
            if (!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);//導到原始要求網址
            }
            else
            {
                return RedirectToAction("Privacy", "home");//登入後頁面
            }
        }

        
        public async Task<IActionResult> ReloadCookie()
        {            
            //var b = HttpContext.User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Name) != null ? HttpContext.User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Name).Value : "";            

            List<Claim> new_claims = new List<Claim>();

            foreach (Claim claim in HttpContext.User.Claims)
            {
                new_claims.Add(new Claim(claim.Type, claim.Value + "_1"));
            }

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            await setClaimsPrincipal(new_claims);

            return RedirectToAction("claimname", "home");//導至登入頁
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        //登出 Action 記得別加上[Authorize]，不管用戶是否登入，都可以執行Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("nologin", "login");//導至登入頁
        }

        private async Task setClaimsPrincipal(List<Claim> claim)
        {
            ////建立證件，類似你的駕照或護照
            ////Scheme必填
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
            ////將 ClaimsIdentity 設定給 ClaimsPrincipal (持有者) 
            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
            ////執行登入，相當於以前的FormsAuthentication.SetAuthCookie()
            await HttpContext.SignInAsync(principal, new AuthenticationProperties()
            {
                AllowRefresh = true,
                // IsPersistent = false：瀏覽器關閉立馬登出；IsPersistent = true 就變成常見的Remember Me功能
                //用戶頁面停留太久，逾期時間，在此設定的話會覆蓋Startup.cs裡的逾期設定
                IsPersistent = false,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(2)
            });
        }

    }
}
