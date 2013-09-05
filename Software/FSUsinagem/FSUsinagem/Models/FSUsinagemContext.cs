using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    public class FSUsinagemContext : DbContext
    {
        public FSUsinagemContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TipoDeProduto> TiposDeProduto { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<Produto> Produtoes { get; set; }

        public DbSet<PessoaFisica> PessoaFisicas { get; set; }

        public DbSet<Banco> Bancoes { get; set; }

        public DbSet<EstadoDoPedido> EstadoDoPedidoes { get; set; }
    }
}