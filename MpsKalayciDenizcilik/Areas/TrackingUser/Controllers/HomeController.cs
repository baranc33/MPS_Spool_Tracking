using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.TrackingUser.Controllers
{
    public class HomeController : Controller
    {
        [Area("TrackingUser")]
        [Authorize(Roles = "TrackingUser")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
