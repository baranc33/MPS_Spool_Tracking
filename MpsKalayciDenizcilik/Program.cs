using DataAccess.EntitiesRepostory;
using Microsoft.EntityFrameworkCore;
using MpsKalayciDenizcilik.Models.Extentions.Programcs;
using MpsService.Extentions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var config = builder.Configuration;
var connetionstring = config.GetConnectionString("mysql");
var version = new MySqlServerVersion(new Version(10, 6, 18));



builder.Services.AddDbContext<MpsDbContext>(opt =>
{
    opt.UseMySql(connetionstring, version);
});

CustomIdentitySettings.AddIdentityWitjExtentions(builder.Services);


builder.Services.LoadMyServices();
builder.Services.ConfigureApplicationCookie(opt =>
{
    var cookieBuilder = new CookieBuilder();

    cookieBuilder.Name = "KalayciCoocki";// cookie ismi
    opt.LoginPath = new PathString("/Home/Login");// giri� yapmad�ysa y�nlendirilecek sayfa
    opt.LogoutPath = new PathString("/Home/logout");
    opt.AccessDeniedPath = new PathString("/Home/AccessDenied");
    opt.Cookie = cookieBuilder;
    opt.ExpireTimeSpan = TimeSpan.FromDays(30);// cookie s�resi
    opt.SlidingExpiration = true;// giri� yapt��� s�rece time span s�f�rlan�r
});


















var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();








app.MapAreaControllerRoute(name: "Admin",
    areaName: "Admin", pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "Manager",
    areaName: "Manager", pattern: "Manager/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "WorkShopManager",
    areaName: "WorkShopManager", pattern: "WorkShopManager/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "WorkShopEmployee",
    areaName: "WorkShopEmployee", pattern: "WorkShopEmployee/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "TallyClerk",
    areaName: "TallyClerk", pattern: "TallyClerk/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "ChefEngineer",
    areaName: "ChefEngineer", pattern: "ChefEngineer/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "Engineer",
    areaName: "Engineer", pattern: "Engineer/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "Stock",
    areaName: "Stock", pattern: "Stock/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(name: "TrackingUser",
    areaName: "TrackingUser", pattern: "TrackingUser/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
