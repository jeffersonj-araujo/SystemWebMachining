using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Valor de Custo")]
        public decimal? ValorDeCusto { get; set; }

        [Display(Name = "Valor de Venda")]
        public decimal? ValorDeVenda { get; set; }

        [ForeignKey("TipoDeProduto")]
        public int TipoDeProdutoId { get; set; }
        public virtual TipoDeProduto TipoDeProduto { get; set; }
    }
}