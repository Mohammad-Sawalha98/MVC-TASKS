using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API_practice.Models;

namespace API_practice.Controllers
{
    public class emploesController : ApiController
    {
        private empEntities1 db = new empEntities1();

        // GET: api/emploes
        public IQueryable<emplo> Getemploes()
        {
            return db.emploes;
        }

        // GET: api/emploes/5
        [ResponseType(typeof(emplo))]
        public IHttpActionResult Getemplo(int id)
        {
            emplo emplo = db.emploes.Find(id);
            if (emplo == null)
            {
                return NotFound();
            }

            return Ok(emplo);
        }

        // PUT: api/emploes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putemplo(int id, emplo emplo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != emplo.ID)
            {
                return BadRequest();
            }

            db.Entry(emplo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!emploExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/emploes
        [ResponseType(typeof(emplo))]
        public IHttpActionResult Postemplo(emplo emplo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.emploes.Add(emplo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = emplo.ID }, emplo);
        }

        // DELETE: api/emploes/5
        [ResponseType(typeof(emplo))]
        public IHttpActionResult Deleteemplo(int id)
        {
            emplo emplo = db.emploes.Find(id);
            if (emplo == null)
            {
                return NotFound();
            }

            db.emploes.Remove(emplo);
            db.SaveChanges();

            return Ok(emplo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool emploExists(int id)
        {
            return db.emploes.Count(e => e.ID == id) > 0;
        }
    }
}