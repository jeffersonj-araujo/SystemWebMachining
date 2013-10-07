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
    public class ItemDoPedidoController : Controller
    {
        private FSUsinagemContext db = new FSUsinagemContext();

        //
        // GET: /ItemDoPedido/

        public ActionResult Index()
        {
            var itensdopedido = db.ItensDoPedido.Include(i => i.Produto).Include(i => i.Pedido);
            return View(itensdopedido.ToList());
        }

        //
        // GET: /ItemDoPedido/Details/5

        public ActionResult Details(int id = 0)
        {
            ItemDoPedido itemdopedido = db.ItensDoPedido.Find(id);
            if (itemdopedido == null)
            {
                return HttpNotFound();
            }
            return View(itemdopedido);
        }

        //
        // GET: /ItemDoPedido/Create

        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Codigo");
            ViewBag.PedidoId = new SelectList(db.Pedidoes, "PedidoId", "PedidoId");
            return View();
        }

        //
        // POST: /ItemDoPedido/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemDoPedido itemdopedido)
        {
            if (ModelState.IsValid)
            {
                db.ItensDoPedido.Add(itemdopedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Codigo", itemdopedido.ProdutoId);
            ViewBag.PedidoId = new SelectList(db.Pedidoes, "PedidoId", "PedidoId", itemdopedido.PedidoId);
            return View(itemdopedido);
        }

        //
        // GET: /ItemDoPedido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ItemDoPedido itemdopedido = db.ItensDoPedido.Find(id);
            if (itemdopedido == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Codigo", itemdopedido.ProdutoId);
            ViewBag.PedidoId = new SelectList(db.Pedidoes, "PedidoId", "PedidoId", itemdopedido.PedidoId);
            return View(itemdopedido);
        }

        //
        // POST: /ItemDoPedido/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemDoPedido itemdopedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemdopedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Codigo", itemdopedido.ProdutoId);
            ViewBag.PedidoId = new SelectList(db.Pedidoes, "PedidoId", "PedidoId", itemdopedido.PedidoId);
            return View(itemdopedido);
        }

        //
        // GET: /ItemDoPedido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ItemDoPedido itemdopedido = db.ItensDoPedido.Find(id);
            if (itemdopedido == null)
            {
                return HttpNotFound();
            }
            return View(itemdopedido);
        }

        //
        // POST: /ItemDoPedido/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemDoPedido itemdopedido = db.ItensDoPedido.Find(id);
            db.ItensDoPedido.Remove(itemdopedido);
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