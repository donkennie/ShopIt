using Microsoft.AspNetCore.Mvc;

namespace ShopIt.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
