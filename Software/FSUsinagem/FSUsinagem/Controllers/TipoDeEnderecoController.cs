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
    public class TipoDeEnderecoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /TipoDeEndereco/

        public ActionResult Index()
        {
            return View(db.TiposDeEndereco.ToList());
        }

        //
        // GET: /TipoDeEndereco/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoDeEndereco tipodeendereco = db.TiposDeEndereco.Find(id);
            if (tipodeendereco == null)
            {
                return HttpNotFound();
            }
            return View(tipodeendereco);
        }

        //
        // GET: /TipoDeEndereco/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoDeEndereco/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDeEndereco tipodeendereco)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeEndereco.Add(tipodeendereco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodeendereco);
        }

        //
        // GET: /TipoDeEndereco/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoDeEndereco tipodeendereco = db.TiposDeEndereco.Find(id);
            if (tipodeendereco == null)
            {
                return HttpNotFound();
            }
            return View(tipodeendereco);
        }

        //
        // POST: /TipoDeEndereco/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoDeEndereco tipodeendereco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodeendereco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodeendereco);
        }

        //
        // GET: /TipoDeEndereco/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoDeEndereco tipodeendereco = db.TiposDeEndereco.Find(id);
            if (tipodeendereco == null)
            {
                return HttpNotFound();
            }
            return View(tipodeendereco);
        }

        //
        // POST: /TipoDeEndereco/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeEndereco tipodeendereco = db.TiposDeEndereco.Find(id);
            db.TiposDeEndereco.Remove(tipodeendereco);
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