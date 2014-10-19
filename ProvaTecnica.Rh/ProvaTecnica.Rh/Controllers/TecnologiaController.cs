using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaTecnica.Rh.Models;

namespace ProvaTecnica.Rh.Controllers
{
    public class TecnologiaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tecnologia
        public ActionResult Index()
        {
            return View(db.Tecnologia.ToList());
        }

        // GET: Tecnologia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tecnologia tecnologia = db.Tecnologia.Find(id);
            if (tecnologia == null)
            {
                return HttpNotFound();
            }
            return View(tecnologia);
        }

        // GET: Tecnologia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tecnologia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTecnologia,nomeTecnologia,peso")] Tecnologia tecnologia)
        {
            if (ModelState.IsValid)
            {
                db.Tecnologia.Add(tecnologia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tecnologia);
        }

        // GET: Tecnologia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tecnologia tecnologia = db.Tecnologia.Find(id);
            if (tecnologia == null)
            {
                return HttpNotFound();
            }
            return View(tecnologia);
        }

        // POST: Tecnologia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTecnologia,nomeTecnologia,peso")] Tecnologia tecnologia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecnologia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecnologia);
        }

        // GET: Tecnologia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tecnologia tecnologia = db.Tecnologia.Find(id);
            if (tecnologia == null)
            {
                return HttpNotFound();
            }
            return View(tecnologia);
        }

        // POST: Tecnologia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tecnologia tecnologia = db.Tecnologia.Find(id);
            db.Tecnologia.Remove(tecnologia);
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
