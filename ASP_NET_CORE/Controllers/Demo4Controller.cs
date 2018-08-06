using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_2.Controllers
{
    public class Demo4Controller : Controller
    {
        public IActionResult Index4()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = "1",
                    Name = "sai",
                    Photo = "thumb1.jpg",
                    Price = 5.5,
                    Quantity = 4

                },
                new Product()
                {
                    Id = "2",
                    Name = "kumar",
                    Photo = "thumb2.jpg",
                    Price = 6,
                    Quantity = 3

                },

                new Product()
                {
                    Id = "3",
                    Name = "yadav",
                    Photo = "thumb3.jpg",
                    Price = 7,
                    Quantity = 5

                }

            };
            ViewBag.products = products;
            return View();
        }
    }
}
