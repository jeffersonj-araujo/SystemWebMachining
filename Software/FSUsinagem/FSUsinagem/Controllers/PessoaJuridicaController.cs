using FSUsinagem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSUsinagem.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        private void AjustaTipoEndereco(PessoaJuridica pessoaJuridica)
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

            pessoaJuridica.EnderecoPrincipal().TipoDeEndereco = tipoEnderecoPrincipal;
            pessoaJuridica.EnderecoCobranca().TipoDeEndereco = tipoEnderecoCobranca;
            pessoaJuridica.EnderecoEntrega().TipoDeEndereco = tipoEnderecoEntrega;
        }

        public ActionResult Index()
        {
            var Lista = new List<PessoaJuridicaDto>();
            db.PessoasJuridicas.ToList().ForEach(i => Lista.Add(new PessoaJuridicaDto(i)));
            return View(Lista);
        }

        //
        // GET: /PessoasJuridica/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PessoasJuridica/Create

        public ActionResult Create()
        {
            ViewBag.TipoDeCadastroId = new SelectList(db.TiposDeCadastro, "TipoDeCadastroId", "Descricao");
            return View();
        }

        //
        // POST: /PessoasJuridica/Create

        [HttpPost]
        public ActionResult Create(PessoaJuridicaDto PessoaJuridicaDto)
        {
            if (ModelState.IsValid)
            {
                PessoaJuridica pj = PessoaJuridicaDto.ToEntity();
                AjustaTipoEndereco(pj);
                db.PessoasJuridicas.Add(pj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(PessoaJuridicaDto);
        }

        //
        // GET: /PessoasJuridica/Edit/5

        public ActionResult Edit(int id)
        {
            PessoaJuridica pessoaJuridica = db.PessoasJuridicas.Find(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoDeCadastroId = new SelectList(db.TiposDeCadastro, "TipoDeCadastroId", "Descricao", pessoaJuridica.TipoDeCadastroId);
            return View(new PessoaJuridicaDto(pessoaJuridica));
        }

        //
        // POST: /PessoasJuridica/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaJuridicaDto pessoaJuridicaDto)
        {
            if (ModelState.IsValid)
            {
                PessoaJuridica pj = db.PessoasJuridicas.Find(pessoaJuridicaDto.PessoaId);
                pessoaJuridicaDto.AssignTo(pj);
                db.Entry(pj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoDeCadastroId = new SelectList(db.TiposDeCadastro, "TipoDeCadastroId", "Descricao", pessoaJuridicaDto.TipoDeCadastroId);
            return View(pessoaJuridicaDto);
        }

        //
        // GET: /PessoasJuridica/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PessoaJuridica pessoaJuridica = db.PessoasJuridicas.Find(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            return View(new PessoaJuridicaDto(pessoaJuridica));
        }

        //
        // POST: /PessoasJuridica/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PessoaJuridica pessoaJuridica = db.PessoasJuridicas.Find(id);
            pessoaJuridica.Enderecos.Clear();
            db.PessoasJuridicas.Remove(pessoaJuridica);
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
