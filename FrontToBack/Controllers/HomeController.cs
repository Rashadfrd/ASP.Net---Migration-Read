using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public void CreateProduct()
        //{
        //    Product prod1 = new Product
        //    {
        //        Id = 1,
        //        Name = "Fusion",
        //        Price = 100,
        //        ImageUrl = "p50.jpg"
        //    };

        //    Product prod2 = new Product
        //    {
        //        Id = 2,
        //        Name = "Fusion",
        //        Price = 100,
        //        ImageUrl = "p50.jpg"
        //    };

        //    Product prod3 = new Product
        //    {
        //        Id = 3,
        //        Name = "Fusion",
        //        Price = 100,
        //        ImageUrl = "p50.jpg"
        //    };

        //    Product prod4 = new Product
        //    {
        //        Id = 4,
        //        Name = "Fusion",
        //        Price = 100,
        //        ImageUrl = "p50.jpg"
        //    };

        //    List<Product> products = new List<Product>();
        //    products.Add(prod1);
        //    products.Add(prod2);
        //    products.Add(prod3);
        //    products.Add(prod4);

        //    using (StreamWriter sw = new StreamWriter("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\products.json"))
        //    {
        //        sw.Write(JsonConvert.SerializeObject(products));
        //    }
        //}
    }
}
