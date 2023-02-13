using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace handlingErrorPractice.Controllers
{
    public class infoController : Controller
    {
        // GET: info
        public ActionResult Index()
        {
            return View();
        }

        // GET: info/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: info/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: info/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: info/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: info/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: info/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
