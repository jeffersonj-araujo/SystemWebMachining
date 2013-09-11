using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FSUsinagem.Models;

namespace FSUsinagem.Controllers
{
    public class EstadoDoPedidoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /EstadoDoPedido/

        public ActionResult Index()
        {
            return View(db.EstadosDePedido.ToList());
        }

        //
        // GET: /EstadoDoPedido/Details/5

        public ActionResult Details(int id = 0)
        {
            EstadoDoPedido estadodopedido = db.EstadosDePedido.Find(id);
            if (estadodopedido == null)
            {
                return HttpNotFound();
            }
            return View(estadodopedido);
        }

        //
        // GET: /EstadoDoPedido/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EstadoDoPedido/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstadoDoPedido estadodopedido)
        {
            if (ModelState.IsValid)
            {
                db.EstadosDePedido.Add(estadodopedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadodopedido);
        }

        //
        // GET: /EstadoDoPedido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EstadoDoPedido estadodopedido = db.EstadosDePedido.Find(id);
            if (estadodopedido == null)
            {
                return HttpNotFound();
            }
            return View(estadodopedido);
        }

        //
        // POST: /EstadoDoPedido/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstadoDoPedido estadodopedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadodopedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadodopedido);
        }

        //
        // GET: /EstadoDoPedido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EstadoDoPedido estadodopedido = db.EstadosDePedido.Find(id);
            if (estadodopedido == null)
            {
                return HttpNotFound();
            }
            return View(estadodopedido);
        }

        //
        // POST: /EstadoDoPedido/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadoDoPedido estadodopedido = db.EstadosDePedido.Find(id);
            db.EstadosDePedido.Remove(estadodopedido);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}