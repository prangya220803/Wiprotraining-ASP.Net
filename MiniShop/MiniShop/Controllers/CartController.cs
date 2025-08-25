using Microsoft.AspNetCore.Mvc;
using MiniShop.Infrastructure;
using MiniShop.Models;
using MiniShop.Services;

namespace MiniShop.Controllers
{
    public class CartController(IProductRepository repo) : Controller
    {
        private List<CartItem> GetCart()
        => HttpContext.Session.GetObject<List<CartItem>>(SessionKeys.Cart) ?? new();

        private void SaveCart(List<CartItem> cart)
            => HttpContext.Session.SetObject(SessionKeys.Cart, cart);

        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Add(int id)
        {
            var product = repo.Get(id);
            if (product is null) return NotFound();

            var cart = GetCart();
            var line = cart.FirstOrDefault(x => x.ProductId == id);
            if (line is null)
                cart.Add(new CartItem { ProductId = id, ProductName = product.Name, UnitPrice = product.Price, Quantity = 1 });
            else
                line.Quantity += 1;

            SaveCart(cart);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Update(int id, int qty)
        {
            var cart = GetCart();
            var line = cart.FirstOrDefault(x => x.ProductId == id);
            if (line is not null)
            {
                line.Quantity = Math.Max(1, qty);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Remove(int id)
        {
            var cart = GetCart();
            cart.RemoveAll(x => x.ProductId == id);
            SaveCart(cart);
            return RedirectToAction("Index");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Clear()
        {
            SaveCart(new());
            return RedirectToAction("Index");
        }
    }
}
