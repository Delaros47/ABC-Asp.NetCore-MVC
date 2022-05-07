using Microsoft.AspNetCore.Mvc;

namespace NorthwindUI.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
