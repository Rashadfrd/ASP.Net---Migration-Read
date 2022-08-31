using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            using (StreamReader sr = new StreamReader("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List < Product >> (sr.ReadToEnd());
            };
            return View(products);
        }
    }
}
