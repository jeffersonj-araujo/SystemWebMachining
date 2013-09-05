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
    public class TipoDeProdutoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /TipoDeProduto/

        public ActionResult Index()
        {
            return View(db.TiposDeProduto.ToList());
        }

        //
        // GET: /TipoDeProduto/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoDeProduto tipodeproduto = db.TiposDeProduto.Find(id);
            if (tipodeproduto == null)
            {
                return HttpNotFound();
            }
            return View(tipodeproduto);
        }

        //
        // GET: /TipoDeProduto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoDeProduto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDeProduto tipodeproduto)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeProduto.Add(tipodeproduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodeproduto);
        }

        //
        // GET: /TipoDeProduto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoDeProduto tipodeproduto = db.TiposDeProduto.Find(id);
            if (tipodeproduto == null)
            {
                return HttpNotFound();
            }
            return View(tipodeproduto);
        }

        //
        // POST: /TipoDeProduto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoDeProduto tipodeproduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodeproduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodeproduto);
        }

        //
        // GET: /TipoDeProduto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoDeProduto tipodeproduto = db.TiposDeProduto.Find(id);
            if (tipodeproduto == null)
            {
                return HttpNotFound();
            }
            return View(tipodeproduto);
        }

        //
        // POST: /TipoDeProduto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeProduto tipodeproduto = db.TiposDeProduto.Find(id);
            db.TiposDeProduto.Remove(tipodeproduto);
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