using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Data;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext db;

        public ProductController(AppDbContext db)
        {
            this.db = db;
        }

        // READ
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // UPDATE
        public IActionResult Edit(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);

            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}