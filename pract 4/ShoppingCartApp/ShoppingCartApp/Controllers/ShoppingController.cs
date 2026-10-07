using Microsoft.AspNetCore.Mvc;
using ShoppingCartApp.Models;
using System.Text.Json;

namespace ShoppingCartApp.Controllers
{
    public class ShoppingController : Controller
    {
        static List<Product> P = new()
        {
            new(){Id=1,Name="Laptop",Price=55000},
            new(){Id=2,Name="Mouse",Price=600},
            new(){Id=3,Name="Keyboard",Price=1200},
            new(){Id=4,Name="Monitor",Price=9000}
        };

        public IActionResult Index() => View(P);
        public IActionResult Cart() => View(Get());

        public IActionResult AddToCart(int id)
        {
            var c = Get(); var p = P.FirstOrDefault(x => x.Id == id);
            var i = c.FirstOrDefault(x => x.Product.Id == id);
            if (p != null)
                if (i == null) c.Add(new() { Product = p, Quantity = 1 });
                else i.Quantity++;
            Save(c); return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var c = Get();
            c.RemoveAll(x => x.Product.Id == id);
            Save(c); return RedirectToAction("Cart");
        }

        public IActionResult ClearCart()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Cart");
        }

        List<CartItem> Get()
        {
            var s = HttpContext.Session.GetString("Cart");
            return string.IsNullOrEmpty(s) ? new() : JsonSerializer.Deserialize<List<CartItem>>(s)!;
        }

        void Save(List<CartItem> c) =>
            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(c));
    }
}