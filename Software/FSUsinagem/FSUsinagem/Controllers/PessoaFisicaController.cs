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
    public class PessoaFisicaController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /PessoaFisica/

        public ActionResult Index()
        {
            return View(db.PessoaFisicas.ToList());
        }

        //
        // GET: /PessoaFisica/Details/5

        public ActionResult Details(int id = 0)
        {
            PessoaFisica pessoafisica = db.PessoaFisicas.Find(id);
            if (pessoafisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoafisica);
        }

        //
        // GET: /PessoaFisica/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PessoaFisica/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaFisica pessoafisica)
        {
            if (ModelState.IsValid)
            {
                db.PessoaFisicas.Add(pessoafisica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoafisica);
        }

        //
        // GET: /PessoaFisica/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PessoaFisica pessoafisica = db.PessoaFisicas.Find(id);
            if (pessoafisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoafisica);
        }

        //
        // POST: /PessoaFisica/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaFisica pessoafisica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoafisica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoafisica);
        }

        //
        // GET: /PessoaFisica/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PessoaFisica pessoafisica = db.PessoaFisicas.Find(id);
            if (pessoafisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoafisica);
        }

        //
        // POST: /PessoaFisica/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PessoaFisica pessoafisica = db.PessoaFisicas.Find(id);
            db.PessoaFisicas.Remove(pessoafisica);
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