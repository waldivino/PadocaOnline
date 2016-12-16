using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PadocaOnline.Controllers
{
    public class FornadasController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Fornadas
        public ActionResult Index()
        {
            return View(db.FornadaContexto.ToList());
        }

        // GET: Fornadas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FornadaDAL fornadaDAL = db.FornadaContexto.Find(id);
            if (fornadaDAL == null)
            {
                return HttpNotFound();
            }
            return View(fornadaDAL);
        }

        // GET: Fornadas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornadas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,descricao,dataHora")] FornadaDAL fornadaDAL)
        {
            if (ModelState.IsValid)
            {
                db.FornadaContexto.Add(fornadaDAL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fornadaDAL);
        }

        // GET: Fornadas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FornadaDAL fornadaDAL = db.FornadaContexto.Find(id);
            if (fornadaDAL == null)
            {
                return HttpNotFound();
            }
            return View(fornadaDAL);
        }

        // POST: Fornadas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,descricao,dataHora")] FornadaDAL fornadaDAL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fornadaDAL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fornadaDAL);
        }

        // GET: Fornadas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FornadaDAL fornadaDAL = db.FornadaContexto.Find(id);
            if (fornadaDAL == null)
            {
                return HttpNotFound();
            }
            return View(fornadaDAL);
        }

        // POST: Fornadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FornadaDAL fornadaDAL = db.FornadaContexto.Find(id);
            db.FornadaContexto.Remove(fornadaDAL);
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
