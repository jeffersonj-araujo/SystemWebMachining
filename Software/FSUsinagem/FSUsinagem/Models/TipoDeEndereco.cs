using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("TiposDeEndereco")]
    public class TipoDeEndereco
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TipoDeEnderecoId { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual List<Endereco> Enderecos { get; set; }
    }
}