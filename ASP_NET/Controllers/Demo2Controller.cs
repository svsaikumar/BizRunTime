using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_2.Controllers
{
    public class Demo2Controller : Controller
    {
        public IActionResult Index2()
        {
            ViewBag.age = 20;
            ViewBag.fullname = "Kevin";
            ViewBag.status = true;
            ViewBag.price = 4.5;
            ViewBag.birthday = DateTime.Now;
            return View();
        }
    }
}