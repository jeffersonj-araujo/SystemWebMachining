using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("TiposDeCadastro")]
    public class TipoDeCadastro
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TipoDeCadastroId { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual List<Pessoa> Pessoas { get; set; }
    }
}