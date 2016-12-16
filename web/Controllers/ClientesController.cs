using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class ClientesController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteDAL clienteDAL = db.ClienteContexto.Find(id);
            if (clienteDAL == null)
            {
                return HttpNotFound();
            }
            return View(clienteDAL);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,email,endereco")] ClienteDAL clienteDAL)
        {
            if (ModelState.IsValid)
            {
                db.ClienteContexto.Add(clienteDAL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienteDAL);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteDAL clienteDAL = db.ClienteContexto.Find(id);
            if (clienteDAL == null)
            {
                return HttpNotFound();
            }
            return View(clienteDAL);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,email,endereco")] ClienteDAL clienteDAL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteDAL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteDAL);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteDAL clienteDAL = db.ClienteContexto.Find(id);
            if (clienteDAL == null)
            {
                return HttpNotFound();
            }
            return View(clienteDAL);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClienteDAL clienteDAL = db.ClienteContexto.Find(id);
            db.ClienteContexto.Remove(clienteDAL);
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