using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_2.Controllers
{
    public class Demo3Controller : Controller
    {
        public IActionResult Index3()
        {
            Product product = new Product()
            {
                Id = "po1",
                Name = "saikumar",
                Photo = "thumb1.jpg",
                Price = 5.5,
                Quantity = 4

            };
            ViewBag.product = product;
            return View();
        }
    }
}