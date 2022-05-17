using WebProject.Service;
using Microsoft.EntityFrameworkCore;
using WebProject.Modelss;
using WebProject.Modelsss;

var builder = WebApplication.CreateBuilder(args);

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
