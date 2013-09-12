using FSUsinagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSUsinagem.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();
        //
        // GET: /PessoaFisica/

        public ActionResult Index()
        {
            var Lista = new List<PessoaFisicaDto>();
            db.PessoasFisicas.ToList().ForEach(p => Lista.Add(new PessoaFisicaDto(p)));
            return View(Lista);
        }

        //
        // GET: /PessoaFisica/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PessoaFisica/Create

        public ActionResult Create()
        {
            ViewBag.TipoDeCadastroId = new SelectList(db.TiposDeCadastro, "TipoDeCadastroId", "Descricao");
            return View();
        }

        //
        // POST: /PessoaFisica/Create

        [HttpPost]
        public ActionResult Create(PessoaFisicaDto pessoaFisicaDto)
        {
            if (ModelState.IsValid)
            {
                db.PessoasFisicas.Add(pessoaFisicaDto.ToEntity());
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoaFisicaDto);
        }

        //
        // GET: /PessoaFisica/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PessoaFisica/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PessoaFisica/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PessoaFisica/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
