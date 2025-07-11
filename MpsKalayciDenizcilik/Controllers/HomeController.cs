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
            _userService=userService;
            _logger = logger;
        }












        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                string result = await _userService.Login(model);
                if (result!="Success")
                    ModelState.AddModelError("", result);
                else
                {
                    // giriþ baþarýlý
               
                    ICollection<string> userRoles = await _userService.GetRolesAsync(model.UserName);


                    foreach (var item in userRoles)
                    {

                        switch (item)
                        {
                            case "Admin": return RedirectToAction("Index", "Home", new { area = "Admin" });
                            case "Manager": return RedirectToAction("Index", "Home", new { area = "Manager" });
                            case "WorkShopManager": return RedirectToAction("Index", "Home", new { area = "WorkShopManager" });
                            case "WorkShopEmployee": return RedirectToAction("Index", "Home", new { area = "WorkShopEmployee" });
                            case "TallyClerk": return RedirectToAction("Index", "Home", new { area = "TallyClerk" });
                            case "ChefEngineer": return RedirectToAction("Index", "Home", new { area = "ChefEngineer" });
                            case "Engineer": return RedirectToAction("Index", "Home", new { area = "Engineer" });
                            case "Stock": return RedirectToAction("Index", "Home", new { area = "Stock" });
                            case "TrackingUser": return RedirectToAction("Index", "Home", new { area = "TrackingUser" });

                        }
                       
                    }


                }
            }
            else
                ModelState.AddModelError("", "Geçersiz kullanýcý adý veya  þifresi");

            return View(model);
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
                TempData["SuccessMessage"]="üyelik baþarýlý";
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
