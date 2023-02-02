using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_practice.Controllers
{
    public class infoController : Controller
    {
        // GET: info
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult about()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }
    }
}