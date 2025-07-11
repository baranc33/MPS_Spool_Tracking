using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.WorkShopManager.Controllers
{
    public class HomeController : Controller
    {
        [Area("WorkShopManager")]
        [Authorize(Roles = "WorkShopManager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
