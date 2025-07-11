using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.WorkShopEmployee.Controllers
{
    public class HomeController : Controller
    {
        [Area("WorkShopEmployee")]
        [Authorize(Roles = "WorkShopEmployee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
