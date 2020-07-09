using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;


namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> list = new List<Product>()
        {  
          new Product() { Pid = 1, Pname = "Mac", Price = 1000, stock = 2 },
          new Product() { Pid = 2, Pname = "Dell", Price = 1200, stock = 3 },
          new Product() { Pid = 3, Pname = "Lenovo", Price = 1300, stock = 4 },
        };
       //[Route("GetAllProducts")]
        public IActionResult Index()
        {
            
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product P)

        {
            list.Add(P);
            return RedirectToAction("Index");

        }
        }
}
