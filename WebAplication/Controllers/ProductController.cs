using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "samochód",
                Description = "To jest super auto",
                Name = "BMW"
            };
            return View(product);
        }
        public IActionResult List()
        {
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 2,
                Category = "samochód",
                Description = "To jest super auto",
                Name = "KIA"
                },
                 new Product
                {
                    Id = 3,
                Category = "samochód",
                Description = "To jest super auto",
                Name = "honda"
                }
            };
            return View(productList);
        }
        public IActionResult Data()
        {
            return View();
        }
    }
}
