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

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TipoDeProduto> TiposDeProduto { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<PessoaFisica> PessoasFisicas { get; set; }

        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }

        public DbSet<Banco> Bancos { get; set; }

        public DbSet<EstadoDoPedido> EstadosDePedido { get; set; }

        public DbSet<CodigoDeOperacao> CodigosDeOperacao { get; set; }

        public DbSet<TipoDeCadastro> TiposDeCadastro { get; set; }

        public DbSet<TipoDeEndereco> TiposDeEndereco { get; set; }
    }
}