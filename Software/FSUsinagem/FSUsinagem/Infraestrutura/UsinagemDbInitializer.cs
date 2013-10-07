using FSUsinagem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FSUsinagem.Infraestrutura
{
    public class UsinagemDbInitializer : DropCreateDatabaseIfModelChanges<FSUsinagemContext>
    {
        protected override void Seed(FSUsinagemContext context)
        {
            var tiposDeProduto = new List<TipoDeProduto>
            {
                new TipoDeProduto { Descricao = "Pistão" },
                new TipoDeProduto { Descricao = "Castelo" }
            };
            tiposDeProduto.ForEach(s => context.TiposDeProduto.Add(s));
            context.SaveChanges();
        }
    }
}