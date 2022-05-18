using WebProject.Service;
using Microsoft.EntityFrameworkCore;
using WebProject.Modelss;
using WebProject.Modelsss;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.CookiePolicy;

var builder = WebApplication.CreateBuilder(args);


//宣告增加驗證方式，使用 cookie 驗證
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option => {
    option.Cookie.Name = ".AspNet.SharedCookie";
    //瀏覽器會限制cookie 只能經由HTTP(S) 協定來存取
    option.Cookie.HttpOnly = true;
    //登入頁，未鄧入時會自動導到登入頁
    option.LoginPath = new PathString("/login/login");
    //// If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied  
    option.AccessDeniedPath = new PathString("/home/Privacy");
    //登出網頁(可以省略)
    option.LogoutPath = new PathString("/login/logout");
    //登入有效時間,沒給預設14天
    option.ExpireTimeSpan = TimeSpan.FromMinutes(2);
    //↓資安建議false，白箱弱掃軟體會要求cookie不能延展效期，這時設false變成絕對逾期時間
    //↓如果你的客戶反應明明一直在使用系統卻容易被自動登出的話，你再設為true(然後弱掃policy請客戶略過此項檢查) 
    option.SlidingExpiration = true;
});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<BookService, BookService>();
builder.Services.AddScoped<ActService, ActService>();

builder.Services.AddDbContext<CartsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EF_CARTS"));
});
builder.Services.AddDbContext<EBCNEWSContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EF_EBCNEWS"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

//啟用 cookie 原則功能
app.UseCookiePolicy(new CookiePolicyOptions
{
    HttpOnly = HttpOnlyPolicy.Always,
    // 所有 Cookie.SamSite 設置都會被提升為 Strict
    MinimumSameSitePolicy = SameSiteMode.Strict,
    // Cookie.SamSite 設置為 None 的話會被提升為 Lax
    //MinimumSameSitePolicy = SameSiteMode.Lax,  
    // MinimumSameSitePolicy 設置為最寬鬆，因此不會影響 Cookie.SamSite
    //MinimumSameSitePolicy = SameSiteMode.None,
 });

    app.UseRouting();

//啟用身分識別
app.UseAuthentication();
//啟用授權功能,Controller、Action才能加上 [Authorize] 屬性
app.UseAuthorization();
// UseCookiePolicy, UseAuthentication, UseAuthorization這三個前後次序不能對調喔,

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
