using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("EstadosDePedido")]
    public class EstadoDoPedido
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EstadoDoPedidoId { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual List<Pedido> Pedidos { get; set; } 
    }
}