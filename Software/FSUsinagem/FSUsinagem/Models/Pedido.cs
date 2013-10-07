using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        public Pedido()
        {
            DataDeEmissao = DateTime.Now;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Número do Pedido")]
        public int PedidoId { get; set; }

        [Required]
        [Display(Name = "Data de Emissão")]
        public DateTime DataDeEmissao { get; set; }

        [Display(Name = "Previsão de Entrega")]
        public DateTime? PrevisaoDeEntrega { get; set; }

        public virtual List<ItemDoPedido> ItensDoPedido { get; set; }

        [ForeignKey("EstadoDoPedido")]
        public int EstadoDoPedidoId { get; set; }
        public virtual EstadoDoPedido EstadoDoPedido { get; set; }
    }
}