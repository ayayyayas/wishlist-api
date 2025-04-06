using Microsoft.AspNetCore.Mvc;

namespace wishlist_api.Controllers
{
    public class WishesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
