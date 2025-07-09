using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModel.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MpsDevelopment.Extentions.Identity;
using MpsDevelopment.Models;
using MpsService.EntityService.IService;
using System.Diagnostics;

namespace MpsDevelopment.Controllers
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
        public async Task<IActionResult> UserList()
        {
            ICollection<UserViewModel> users = await _userService.GetAllUser();
            return View(users);
        }


        [HttpGet]
        public async Task<IActionResult> AddUser()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(UserSaveViewModel model)
        {
            if(!ModelState.IsValid)
            {
                TempData["Message"] = "Gerekli Alanlarý Doldurunuz";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }

            IdentityResult result = await _userService.CreateUser(model);
            if (result.Succeeded)
            {
                TempData["Message"] = "üyelik baþarýlý";
                TempData["MessageColor"] = "alert-success";
                return RedirectToAction("UserList");

            }


            ModelState.AddModelErrorList(result.Errors.Select(x => x.Description).ToList());


            return View();
        }







        [HttpGet]
        public async Task<IActionResult> ModifiedUser(int UserId)
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ModifiedUser()
        {
            return View();
        }






        [HttpGet]
        public  IActionResult Index()
        {


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
