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
    public class CodigoDeOperacaoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /CodigoDeOperacao/

        public ActionResult Index()
        {
            return View(db.CodigosDeOperacao.ToList());
        }

        //
        // GET: /CodigoDeOperacao/Details/5

        public ActionResult Details(int id = 0)
        {
            CodigoDeOperacao codigodeoperacao = db.CodigosDeOperacao.Find(id);
            if (codigodeoperacao == null)
            {
                return HttpNotFound();
            }
            return View(codigodeoperacao);
        }

        //
        // GET: /CodigoDeOperacao/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CodigoDeOperacao/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CodigoDeOperacao codigodeoperacao)
        {
            if (ModelState.IsValid)
            {
                db.CodigosDeOperacao.Add(codigodeoperacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codigodeoperacao);
        }

        //
        // GET: /CodigoDeOperacao/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CodigoDeOperacao codigodeoperacao = db.CodigosDeOperacao.Find(id);
            if (codigodeoperacao == null)
            {
                return HttpNotFound();
            }
            return View(codigodeoperacao);
        }

        //
        // POST: /CodigoDeOperacao/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CodigoDeOperacao codigodeoperacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codigodeoperacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codigodeoperacao);
        }

        //
        // GET: /CodigoDeOperacao/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CodigoDeOperacao codigodeoperacao = db.CodigosDeOperacao.Find(id);
            if (codigodeoperacao == null)
            {
                return HttpNotFound();
            }
            return View(codigodeoperacao);
        }

        //
        // POST: /CodigoDeOperacao/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CodigoDeOperacao codigodeoperacao = db.CodigosDeOperacao.Find(id);
            db.CodigosDeOperacao.Remove(codigodeoperacao);
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