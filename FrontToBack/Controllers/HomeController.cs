using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {

        List<Product> products;

        public HomeController()
        {
            using (StreamReader sr = new StreamReader("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\Files\\product.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
        }
        public IActionResult Index()
        {
            return View(products);
        }
    }
}
