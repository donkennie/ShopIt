using Microsoft.AspNetCore.Mvc;

namespace ShopIt.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
