using Microsoft.AspNetCore.Mvc;
using MiniShop.Infrastructure;
using MiniShop.Models;

namespace MiniShop.Controllers
{
    public class OrderController : Controller
    {
        private List<CartItem> GetCart()
        => HttpContext.Session.GetObject<List<CartItem>>(SessionKeys.Cart) ?? new();

        [HttpGet]
        public IActionResult Checkout()
        {
            var cart = GetCart();
            if (!cart.Any()) return RedirectToAction("Index", "Cart");
            return View(new OrderDetails());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Checkout(OrderDetails details)
        {
            var cart = GetCart();
            if (!ModelState.IsValid) return View(details);
            if (!cart.Any()) return RedirectToAction("Index", "Cart");

            var vm = new BillingViewModel
            {
                UserName = HttpContext.Session.GetString(SessionKeys.UserName),
                Items = cart,
                Details = details
            };

            // Clear the cart after "placing" the order
            HttpContext.Session.SetObject(SessionKeys.Cart, new List<CartItem>());

            return View("Bill", vm);
        }
    }
}
