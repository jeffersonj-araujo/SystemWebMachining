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
    public class BancoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /Banco/

        public ActionResult Index()
        {
            return View(db.Bancoes.ToList());
        }

        //
        // GET: /Banco/Details/5

        public ActionResult Details(int id = 0)
        {
            Banco banco = db.Bancoes.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        //
        // GET: /Banco/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Banco/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Bancoes.Add(banco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(banco);
        }

        //
        // GET: /Banco/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Banco banco = db.Bancoes.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        //
        // POST: /Banco/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banco);
        }

        //
        // GET: /Banco/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Banco banco = db.Bancoes.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        //
        // POST: /Banco/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banco banco = db.Bancoes.Find(id);
            db.Bancoes.Remove(banco);
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