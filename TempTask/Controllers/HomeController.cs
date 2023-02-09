using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempTask.Models;

namespace TempTask.Controllers
{
    
    public class HomeController : Controller
    {
         AddModelEntities obj = new AddModelEntities();
        public ActionResult Index()
        {
            var cat = obj.Products.ToList();

            return View(cat);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}