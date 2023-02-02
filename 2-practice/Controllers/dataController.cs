using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_practice.Controllers
{
    public class dataController : Controller
    {
        // GET: data
        public ActionResult Index()
        {
            ViewBag.Name = "sawalha";


            return View();
        }

    }
}