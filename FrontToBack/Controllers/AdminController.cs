using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FrontToBack.Controllers
{
    public class AdminController : Controller
    {

        private List<Product> products;
        public AdminController()
        {
            using (StreamReader sr = new StreamReader("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\Files\\product.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        public IActionResult GetProduct()
        {
            if (products == null)
            {
                products = new List<Product>();
            }
            return View(products);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (product.OldPrice <= product.NewPrice) return View();
            if (!System.IO.File.Exists("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\wwwroot\\shop\\img\\" + product.ImageUrl)) return View();
            if (products == null)
            {
                products = new List<Product>();
                products.Add(product);
            }
            else
            {
                products.Add(product);
            }
            SaveJson();
            return RedirectToAction(nameof (GetProduct));     
        }

        //public void AddProducts()
        //{
        //    List<Product> products = new List<Product>();
        //    products.Add(new Product { Id = 1, Name = "Stamford Bridge", NewPrice = 120, OldPrice = 140, ImageUrl = "s1.jpg" });
        //    using (StreamWriter sw = new StreamWriter("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\Files\\product.json"))
        //    {
        //        sw.Write(JsonConvert.SerializeObject(products));
        //    }
        //}

        public void SaveJson()
        {
            using (StreamWriter sw = new StreamWriter("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\Files\\product.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }
        }

    }
}
