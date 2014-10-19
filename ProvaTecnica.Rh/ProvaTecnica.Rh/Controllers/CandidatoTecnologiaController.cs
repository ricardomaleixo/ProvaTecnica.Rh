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
    public class CandidatoTecnologiaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CandidatoTecnologia
        public ActionResult Index()
        {
            var candidatoTecnologias = db.CandidatoTecnologias.Include(c => c.Candidato).Include(c => c.Tecnologia);
            return View(candidatoTecnologias.ToList());
        }

        // GET: CandidatoTecnologia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoTecnologia candidatoTecnologia = db.CandidatoTecnologias.Find(id);
            if (candidatoTecnologia == null)
            {
                return HttpNotFound();
            }
            return View(candidatoTecnologia);
        }

        // GET: CandidatoTecnologia/Create
        public ActionResult Create()
        {
            ViewBag.idCandidato = new SelectList(db.Candidato, "idCandidato", "nomeCandidato");
            ViewBag.idTecnologia = new SelectList(db.Tecnologia, "idTecnologia", "nomeTecnologia");
            return View();
        }

        // POST: CandidatoTecnologia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCandidatoTecnologia,idCandidato,idTecnologia")] CandidatoTecnologia candidatoTecnologia)
        {
            if (ModelState.IsValid)
            {
                db.CandidatoTecnologias.Add(candidatoTecnologia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCandidato = new SelectList(db.Candidato, "idCandidato", "nomeCandidato", candidatoTecnologia.idCandidato);
            ViewBag.idTecnologia = new SelectList(db.Tecnologia, "idTecnologia", "nomeTecnologia", candidatoTecnologia.idTecnologia);
            return View(candidatoTecnologia);
        }

        // GET: CandidatoTecnologia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoTecnologia candidatoTecnologia = db.CandidatoTecnologias.Find(id);
            if (candidatoTecnologia == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCandidato = new SelectList(db.Candidato, "idCandidato", "nomeCandidato", candidatoTecnologia.idCandidato);
            ViewBag.idTecnologia = new SelectList(db.Tecnologia, "idTecnologia", "nomeTecnologia", candidatoTecnologia.idTecnologia);
            return View(candidatoTecnologia);
        }

        // POST: CandidatoTecnologia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCandidatoTecnologia,idCandidato,idTecnologia")] CandidatoTecnologia candidatoTecnologia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidatoTecnologia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCandidato = new SelectList(db.Candidato, "idCandidato", "nomeCandidato", candidatoTecnologia.idCandidato);
            ViewBag.idTecnologia = new SelectList(db.Tecnologia, "idTecnologia", "nomeTecnologia", candidatoTecnologia.idTecnologia);
            return View(candidatoTecnologia);
        }

        // GET: CandidatoTecnologia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidatoTecnologia candidatoTecnologia = db.CandidatoTecnologias.Find(id);
            if (candidatoTecnologia == null)
            {
                return HttpNotFound();
            }
            return View(candidatoTecnologia);
        }

        // POST: CandidatoTecnologia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CandidatoTecnologia candidatoTecnologia = db.CandidatoTecnologias.Find(id);
            db.CandidatoTecnologias.Remove(candidatoTecnologia);
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
