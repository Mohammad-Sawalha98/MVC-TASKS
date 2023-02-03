using Practice2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice2.Controllers
{
    public class infoController : Controller
    {
        // GET: info
        public ActionResult Index()

        {
            List<Models.info> inn = new List<info>();
            inn.Add(new info { Name = "Ali", Age = 22 });
            inn.Add(new info { Name = "Ahmad", Age = 25 });
            inn.Add(new info { Name = "yazeed", Age = 19 });

            return View(inn);
        }
    }
}