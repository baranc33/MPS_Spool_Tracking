using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.ChefEngineer.Controllers
{
    [Area("ChefEngineer")]
    [Authorize(Roles = "ChefEngineer")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
