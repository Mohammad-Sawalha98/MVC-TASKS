using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1._1_Feb.Models;

namespace Task1._1_Feb.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Models.Student> stu = new List<Student>();
            stu.Add(new Student { ID = 1, Name = "Mohammad", Major = "Electrical Engineering", Faculity = "Hajjawi" });
            stu.Add(new Student { ID = 2, Name = "Amer", Major = "IT", Faculity = "IT" });
            stu.Add(new Student { ID = 3, Name = "Faten", Major = "Telcommunication Engineering", Faculity = "Hajjawi" });


            return View(stu);
        }
    }
}