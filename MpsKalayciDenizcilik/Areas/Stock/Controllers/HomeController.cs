using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MpsKalayciDenizcilik.Areas.Stock.Controllers
{
    [Area("Stock")]
    [Authorize(Roles = "Stock")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
