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
    public class PedidoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /Pedido/

        public ActionResult Index()
        {
            return View(db.Pedidoes.ToList());
        }

        //
        // GET: /Pedido/Details/5

        public ActionResult Details(int id = 0)
        {
            Pedido pedido = db.Pedidoes.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        //
        // GET: /Pedido/Create

        public ActionResult Create()
        {
            EstadoDoPedido estado = db.EstadosDePedido.Where(e => e.Descricao == "Aguardando Aprovação").FirstOrDefault();
            if (estado == null)
            {
                estado = new EstadoDoPedido { Descricao = "Aguardando Aprovação" };
                db.EstadosDePedido.Add(estado);
                db.SaveChanges();
            }
            return View(new Pedido
            {
                EstadoDoPedidoId = estado.EstadoDoPedidoId
            });
        }

        //
        // POST: /Pedido/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                db.Pedidoes.Add(pedido);
                db.SaveChanges();
                return RedirectToAction("Edit", new {id = pedido.PedidoId});
            }

            return View(pedido);
        }

        //
        // GET: /Pedido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Pedido pedido = db.Pedidoes.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        //
        // POST: /Pedido/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedido);
        }

        //
        // GET: /Pedido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Pedido pedido = db.Pedidoes.Find(id);
            if (pedido == null)
            {
                return HttpNotFound();
            }
            return View(pedido);
        }

        //
        // POST: /Pedido/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pedido pedido = db.Pedidoes.Find(id);
            db.Pedidoes.Remove(pedido);
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