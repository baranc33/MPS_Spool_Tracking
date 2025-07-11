using Core.Concrete.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MpsKalayciDenizcilik.Models;
using MpsKalayciDenizcilik.Models.Extentions.identity;
using MpsService.EntityService.IService;
using System.Diagnostics;

namespace MpsKalayciDenizcilik.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IMpsUserService _userService;
        public HomeController(ILogger<HomeController> logger, IMpsUserService userService)
        {
            _userService = userService;
            _logger = logger;
        }

        private readonly Dictionary<string, object> RoleRedirects = new()
                {
                    { "Admin", new { area = "Admin" } },
                    { "Manager", new { area = "Manager" } },
                    { "WorkShopManager", new { area = "WorkShopManager" } },
                    { "WorkShopEmployee", new { area = "WorkShopEmployee" } },
                    { "WorkShopEmployee", new { area = "WorkShopEmployee" } },
                    { "TallyClerk", new { area = "TallyClerk" } },
                    { "ChefEngineer", new { area = "ChefEngineer" } },
                    { "Engineer", new { area = "Engineer" } },
                    { "TrackingUser", new { area = "TrackingUser" } },
                    { "Stock", new { area = "Stock" } },
                };
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifresi");
                return View(model);
            }
            string result = await _userService.Login(model);
            if (result != "Success")
            {
                ModelState.AddModelError("", result);
                return View(model);
            }
            var userRoles = await _userService.GetRolesAsync(model.UserName);
            foreach (var role in userRoles)
            {
                if (RoleRedirects.TryGetValue(role, out var area))
                {
                    return RedirectToAction("Index", "Home", area);
                }
            }
            return RedirectToAction("Index", "Home");
        }





        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


         



        [HttpGet]
        public async Task<IActionResult> AddUserForAdmin()
        {


            return View();
        }



        [HttpPost]
        public async Task<IActionResult> AddUserForAdmin(UserSaveViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            UserSaveViewModel userSaveViewModel = new UserSaveViewModel(model.UserName, model.Email, model.Password, model.PasswordConfirm);
            IdentityResult result = await _userService.CreateUser(userSaveViewModel);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"]="üyelik başarılı";
                return View("Index");

            }

            ModelState.AddModelErrorList
                (result.Errors.Select(x => x.Description).ToList());

            return View();
        }












        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ServiceTrading()
        {
            return View();
        }
        public IActionResult ServiceMilitary()
        {
            return View();
        }
        public IActionResult ServiceYacht()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Referance()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult SpoolList()
        {
            return View();
        }



    }
}
