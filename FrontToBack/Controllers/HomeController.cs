using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {

        //List<Product> products;

        //public HomeController()
        //{
        //    using (StreamReader sr = new StreamReader("H:\\Rashad\\Code\\ASP.Net\\ASP.Net---Front-to-Back\\FrontToBack\\Files\\product.json"))
        //    {
        //        products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
        //    }
        //}
        private readonly AppDbContext _sql;

        public HomeController(AppDbContext sql)
        {
            _sql = sql;
        }

        public IActionResult Index()
        {
            //return View(products);
            HomeVM vm = new HomeVM();
            vm.Top6 = _sql.Products.Take(6).ToList();
            return View(vm);
        }
    }
}
