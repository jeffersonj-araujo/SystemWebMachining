using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("ItensDoPedido")]
    public class ItemDoPedido
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ItemDoPedidoId { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Valor De Custo")]
        public float ValorDeCusto { get; set; }

        [Display(Name = "Valor De Venda")]
        public float ValorDeVenda { get; set; }

        public virtual List<Produto> Produtos { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}