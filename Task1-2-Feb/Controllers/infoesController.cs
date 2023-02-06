using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Task1_2_Feb.Models;

namespace Task1_2_Feb.Controllers
{
    public class infoesController : Controller
    {
        private EntitiesTask db = new EntitiesTask();

        public ActionResult search(string option, string search)
        {
            //the first parameter is the option that we choose and the second parameter will use the textbox value  


            if (option == "First_Name")
            {
                return View("Index", db.infoes.Where(x => x.First_Name.StartsWith(search) || search == null).ToList());
            }
            if (option == "E_mail")
            {

                return View("Index", db.infoes.Where(x => x.E_mail.StartsWith(search) || search == null).ToList());
            }
            else
            {
                return View("Index", db.infoes.Where(x => x.Last_Name.StartsWith(search) || search == null).ToList());
            }

        }


        // GET: infoes
        public ActionResult Index(string option, string search)
        {

            //if (option == "First_Name")
            //{
            //    //.contain()
            //    return View("Index", db.infoes.Where(x => x.First_Name.StartsWith(search) || search == null).ToList());
            //}
            //if (option == "E_mail")
            //{

            //    return View("Index", db.infoes.Where(x => x.E_mail.StartsWith(search) || search == null).ToList());
            //}
            //else
            //{
            //    return View("Index", db.infoes.Where(x => x.Last_Name.StartsWith(search) || search == null).ToList());
            //}

            return View(db.infoes.ToList());
        }

        // GET: infoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            info info = db.infoes.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // GET: infoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: infoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,First_Name,Last_Name,E_mail,Phone,Age,Job_Title,Gender,Image,CV")] info info, HttpPostedFileBase Image, HttpPostedFileBase CV)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    if (!Image.ContentType.ToLower().StartsWith("image/"))
                    {
                        ModelState.AddModelError("", "file uploaded is not an image");
                        return View(info);
                    }
                    string folderPath = Server.MapPath("~/Content/Images");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string fileName = Path.GetFileName(Image.FileName);
                    string path = Path.Combine(folderPath, fileName);
                    Image.SaveAs(path);
                    info.Image = "../Content/Images/" + fileName;
                }

                else
                {
                    ModelState.AddModelError("", "Please upload an image.");
                    return View(info);
                }

            }

            if (CV != null)
            {
                //if (!image2.ContentType.ToLower().StartsWith("image/"))
                //{
                //    ModelState.AddModelError("", "file uploaded is not an image");
                //    return View(user);
                //}
                string folderPath = Server.MapPath("~/Content/CVs");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileName = Path.GetFileName(CV.FileName);
                string path = Path.Combine(folderPath, fileName);
                CV.SaveAs(path);
                info.CV = "../Content/CVs/" + fileName;
            }



            else
            {
                ModelState.AddModelError("", "Please upload an cv.");
                return View(info);
            }

            db.infoes.Add(info);
            db.SaveChanges();
            return RedirectToAction("Index");



           

        }
        // GET: infoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            info info = db.infoes.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // POST: infoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,First_Name,Last_Name,E_mail,Phone,Age,Job_Title,Gender,Image,CV")] info info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(info);
        }

        // GET: infoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            info info = db.infoes.Find(id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // POST: infoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            info info = db.infoes.Find(id);
            db.infoes.Remove(info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


   } 
      } 
