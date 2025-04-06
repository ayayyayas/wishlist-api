using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wishlist_api.Controllers
{
    public class WishlistsController : Controller
    {
        // GET: WishlistsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WishlistsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WishlistsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WishlistsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WishlistsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WishlistsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WishlistsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WishlistsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
