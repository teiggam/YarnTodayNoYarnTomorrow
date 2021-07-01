using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YarnTodayStorefront.Models;

namespace YarnTodayStorefront.Controllers
{
    public class StorefrontController : Controller
    {
        YarnTodayMoreYarnTomorrowContext db = new YarnTodayMoreYarnTomorrowContext();

        public IActionResult Index()
        {
            List<Product> p = db.Products.ToList();
            return View(p);
        }
        public IActionResult Buy(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Buy(Product p, int Amount)
        {
            try
            {
                if (p.Quantity > 0)
                {
                    if (Amount <= p.Quantity)
                    {
                        p.Quantity -= Amount;
                        db.Products.Update(p);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index", "Storefront");
            }
            catch
            {
                return RedirectToAction("Quantity", "Storefront");
            }
        }

    }

}

