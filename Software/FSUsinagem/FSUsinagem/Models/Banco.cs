using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("Banco")]
    public class Banco
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BancoId { get; set; }

        [Required]
        [Display(Name = "Código Do Banco")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Nome Do Banco")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Agência")]
        public string Agencia { get; set; }

        [Required]
        [Display(Name = "Conta Corrente")]
        public string ContaCorrente { get; set; }

        [Display(Name = "Saldo Do Banco")]
        public decimal? SaldoDoBanco { get; set; }

        [Display(Name = "Data Do Saldo")]
        public DateTime? DataDoSaldo { get; set; }

    }
}