using AuthTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthTask.Controllers
{
    public class HomeController : Controller
    {
       AuthTaskEntities1 obj =  new AuthTaskEntities1();
        public ActionResult Index()
        {
            var x = obj.Products.ToList();
            return View(x);
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