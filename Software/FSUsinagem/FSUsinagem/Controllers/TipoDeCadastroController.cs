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
    public class TipoDeCadastroController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /TipoDeCadastro/

        public ActionResult Index()
        {
            return View(db.TiposDeCadastro.ToList());
        }

        //
        // GET: /TipoDeCadastro/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoDeCadastro tipodecadastro = db.TiposDeCadastro.Find(id);
            if (tipodecadastro == null)
            {
                return HttpNotFound();
            }
            return View(tipodecadastro);
        }

        //
        // GET: /TipoDeCadastro/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoDeCadastro/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDeCadastro tipodecadastro)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeCadastro.Add(tipodecadastro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodecadastro);
        }

        //
        // GET: /TipoDeCadastro/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoDeCadastro tipodecadastro = db.TiposDeCadastro.Find(id);
            if (tipodecadastro == null)
            {
                return HttpNotFound();
            }
            return View(tipodecadastro);
        }

        //
        // POST: /TipoDeCadastro/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoDeCadastro tipodecadastro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodecadastro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodecadastro);
        }

        //
        // GET: /TipoDeCadastro/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoDeCadastro tipodecadastro = db.TiposDeCadastro.Find(id);
            if (tipodecadastro == null)
            {
                return HttpNotFound();
            }
            return View(tipodecadastro);
        }

        //
        // POST: /TipoDeCadastro/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeCadastro tipodecadastro = db.TiposDeCadastro.Find(id);
            db.TiposDeCadastro.Remove(tipodecadastro);
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