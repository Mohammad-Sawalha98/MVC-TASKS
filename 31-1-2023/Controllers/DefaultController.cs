using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace _31_1_2023.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            return "<a href='/hh.jpg' download><img src='/hh.jpg'></a>";
        }

        public string About()
        {
            return "This is About us page";
        }

        public string Contact()
        {
            return "This is Contact us page";
        }
    }
}