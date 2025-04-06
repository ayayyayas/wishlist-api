using Microsoft.AspNetCore.Mvc;

namespace wishlist_api.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
