using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YarnTodayStorefront.Models;

namespace YarnTodayStorefront.Controllers
{
    public class ProductController : Controller
    {
        YarnTodayMoreYarnTomorrowContext db = new YarnTodayMoreYarnTomorrowContext();
        public IActionResult Index()
        {
            List<Product> p = db.Products.ToList();
            return View(p);

        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Details(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }
        public IActionResult Update(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Update(Product p)
        {
            db.Products.Update(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Delete(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }
        [HttpPost]
        public IActionResult Delete(Product p)
        {
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Employee()
        {
            return View();
        }

        public IActionResult ReplenishStock()
        {
            List<Product> inventory = db.Products.ToList();
            List<Product> replenishedInv = new List<Product>();

            foreach (Product p in inventory)
            {
                if (p.Quantity < 10)
                {
                    p.Quantity = 10;
                    db.Products.Update(p);
                    db.SaveChanges();
                    replenishedInv.Add(p);
                }
            }
            return View(replenishedInv);
        }
    }
}
