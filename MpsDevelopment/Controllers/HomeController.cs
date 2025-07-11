using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModels.User;
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
        protected UserManager<MpsUser> _userManager;
        private RoleManager<MpsRole> _roleManager;
        private IMpsRoleService _roleService;

        public HomeController(ILogger<HomeController> logger, IMpsUserService userService, UserManager<MpsUser> userManager, RoleManager<MpsRole> roleManager, IMpsRoleService roleService)
        {
            _roleService=roleService;
            _userService=userService;
            _logger = logger;
            _userManager=userManager;
            _roleManager=roleManager;
        }





        [HttpGet]
        public async Task<IActionResult> AssignRoleToUser(string UserId)
        {
            var currentUser = await _userManager.FindByIdAsync(UserId);
            ViewBag.UserID=UserId;
            var roles = await _roleService.GetAllAsync();

            var roleViewModel = new List<AssignRoleToUserViewModel>();

            var userRoles = await _userManager.GetRolesAsync(currentUser);
            foreach (var role in roles)
            {
                var assignRoleToUserViewModel = new AssignRoleToUserViewModel
                {
                    Id = role.Id,
                    Name = role.Name,
                };
                if (userRoles.Contains(role.Name))
                {
                    assignRoleToUserViewModel.Exist = true;
                }

                roleViewModel.Add(assignRoleToUserViewModel);
            }

            return View(roleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRoleToUser(List<AssignRoleToUserViewModel> requestList, string UserId)
        {

            var User = await _userManager.FindByIdAsync(UserId);

            foreach (var item in requestList)
            {
                if (item.Exist)
                {
                    await _userManager.AddToRoleAsync(User, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(User, item.Name);
                }
            }

            return RedirectToAction("Index");
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
        public async Task<IActionResult> ModifiedUser(string UserId)
        {
            UserViewModel model = await _userService.GetUser(UserId);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ModifiedUser(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Gerekli Alanlarý Doldurunuz";
                TempData["MessageColor"] = "alert-danger";
                return View(model);
            }
            else
            {
                await _userService.ModifiedAsync(model);
                TempData["Message"] = "Ýþlem Baþarýlý";
                TempData["MessageColor"] = "alert-danger";
                return RedirectToAction("UserList");
            }
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
