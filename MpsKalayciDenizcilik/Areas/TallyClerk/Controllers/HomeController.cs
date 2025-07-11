using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.TallyClerk.Controllers
{
    public class HomeController : Controller
    {

        [Area("TallyClerk")]
        [Authorize(Roles = "TallyClerk")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
