using Microsoft.AspNetCore.Mvc;
using MiniShop.Models;

namespace MiniShop.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View();

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            // Demo only: accept any non-empty username
            if (string.IsNullOrWhiteSpace(userName))
            {
                ModelState.AddModelError("", "Username is required");
                return View();
            }

            HttpContext.Session.SetString(SessionKeys.UserName, userName.Trim());
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
