using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}