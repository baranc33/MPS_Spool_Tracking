using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.Engineer.Controllers
{
    [Area("Engineer")]
    [Authorize(Roles = "Engineer")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
