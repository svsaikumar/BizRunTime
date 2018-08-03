using Entity_FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Entity_FM.Controllers
{
    public class NorthwindController : Controller
    {
        NorthWindContext db = new NorthWindContext();
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductTable.ToList();
            return View();
        }
    }
}