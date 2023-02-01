using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace _31_1_2023.Controllers
{
    public class sawalhaController : Controller
    {
        // GET: sawalha
        public int Age()
        {
            return 25;
        }

        public string FullName()
        {
            return "Mohammad Sawalha";
        }

        public ActionResult Hoppies()
        {
            return Content("<head><link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC\" crossorigin=\"anonymous\"><script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM\" crossorigin=\"anonymous\"></script></head><table class='table'><tr><th  class=\"table-dark\" >hopy name</th><th>my age</th><tr/><tr><td>football</td><td>10 years</td><tr/><tr><td>swimming</td><td>from 15-25 yers</td><tr/><table/>");
        }
    }
}