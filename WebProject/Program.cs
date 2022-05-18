using WebProject.Service;
using Microsoft.EntityFrameworkCore;
using WebProject.Modelss;
using WebProject.Modelsss;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.CookiePolicy;

var builder = WebApplication.CreateBuilder(args);


//�ŧi�W�[���Ҥ覡�A�ϥ� cookie ����
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option => {
    option.Cookie.Name = ".AspNet.SharedCookie";
    //�s�����|����cookie �u��g��HTTP(S) ��w�Ӧs��
    option.Cookie.HttpOnly = true;
    //�n�J���A���H�J�ɷ|�۰ʾɨ�n�J��
    option.LoginPath = new PathString("/login/login");
    //// If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied  
    option.AccessDeniedPath = new PathString("/home/Privacy");
    //�n�X����(�i�H�ٲ�)
    option.LogoutPath = new PathString("/login/logout");
    //�n�J���Įɶ�,�S���w�]14��
    option.ExpireTimeSpan = TimeSpan.FromMinutes(2);
    //����w��ĳfalse�A�սc�z���n��|�n�Dcookie���ੵ�i�Ĵ��A�o�ɳ]false�ܦ�����O���ɶ�
    //���p�G�A���Ȥ���������@���b�ϥΨt�Ϋo�e���Q�۰ʵn�X���ܡA�A�A�]��true(�M��z��policy�ЫȤᲤ�L�����ˬd) 
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

//�ҥ� cookie ��h�\��
app.UseCookiePolicy(new CookiePolicyOptions
{
    HttpOnly = HttpOnlyPolicy.Always,
    // �Ҧ� Cookie.SamSite �]�m���|�Q���ɬ� Strict
    MinimumSameSitePolicy = SameSiteMode.Strict,
    // Cookie.SamSite �]�m�� None ���ܷ|�Q���ɬ� Lax
    //MinimumSameSitePolicy = SameSiteMode.Lax,  
    // MinimumSameSitePolicy �]�m���̼e�P�A�]�����|�v�T Cookie.SamSite
    //MinimumSameSitePolicy = SameSiteMode.None,
 });

    app.UseRouting();

//�ҥΨ����ѧO
app.UseAuthentication();
//�ҥα��v�\��,Controller�BAction�~��[�W [Authorize] �ݩ�
app.UseAuthorization();
// UseCookiePolicy, UseAuthentication, UseAuthorization�o�T�ӫe�ᦸ�Ǥ����ճ�,

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
