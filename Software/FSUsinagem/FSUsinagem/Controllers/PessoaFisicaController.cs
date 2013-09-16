using FSUsinagem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSUsinagem.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        private void AjustaTipoEndereco(PessoaFisica pessoaFisica)
        {
            TipoDeEndereco tipoEnderecoPrincipal = db.TiposDeEndereco.Find(TipoDeEndereco.TipoDeEnderecoPrincipal.TipoDeEnderecoId);
            if (tipoEnderecoPrincipal == null)
                tipoEnderecoPrincipal = new TipoDeEndereco(TipoDeEndereco.TipoDeEnderecoPrincipal);

            TipoDeEndereco tipoEnderecoCobranca = db.TiposDeEndereco.FirstOrDefault(t => t.TipoDeEnderecoId == 2);
            if (tipoEnderecoCobranca == null)
                tipoEnderecoCobranca = new TipoDeEndereco(TipoDeEndereco.TipoDeEnderecoCobranca);

            TipoDeEndereco tipoEnderecoEntrega = db.TiposDeEndereco.FirstOrDefault(t => t.TipoDeEnderecoId == 3);
            if (tipoEnderecoEntrega == null)
                tipoEnderecoEntrega = new TipoDeEndereco(TipoDeEndereco.TipoDeEnderecoEntrega);

            pessoaFisica.EnderecoPrincipal().TipoDeEndereco = tipoEnderecoPrincipal;
            pessoaFisica.EnderecoCobranca().TipoDeEndereco = tipoEnderecoCobranca;
            pessoaFisica.EnderecoEntrega().TipoDeEndereco = tipoEnderecoEntrega;
        }

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
                PessoaFisica pf = pessoaFisicaDto.ToEntity();
                AjustaTipoEndereco(pf);
                db.PessoasFisicas.Add(pf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoaFisicaDto);
        }

        //
        // GET: /PessoaFisica/Edit/5

        public ActionResult Edit(int id)
        {
            PessoaFisica pessoaFisica = db.PessoasFisicas.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoDeCadastroId = new SelectList(db.TiposDeCadastro, "TipoDeCadastroId", "Descricao", pessoaFisica.TipoDeCadastroId);
            return View(new PessoaFisicaDto(pessoaFisica));
        }

        //
        // POST: /PessoaFisica/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaFisicaDto pessoaFisicaDto)
        {
            if (ModelState.IsValid)
            {
                PessoaFisica pf = db.PessoasFisicas.Find(pessoaFisicaDto.PessoaId);
                pessoaFisicaDto.AssignTo(pf);
                db.Entry(pf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoDeCadastroId = new SelectList(db.TiposDeCadastro, "TipoDeCadastroId", "Descricao", pessoaFisicaDto.TipoDeCadastroId);
            return View(pessoaFisicaDto);
        }

        //
        // GET: /PessoaFisica/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PessoaFisica pessoaFisica = db.PessoasFisicas.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(new PessoaFisicaDto(pessoaFisica));
        }

        //
        // POST: /PessoaFisica/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PessoaFisica pessoaFisica = db.PessoasFisicas.Find(id);
            pessoaFisica.Enderecos.Clear();
            db.PessoasFisicas.Remove(pessoaFisica);
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
