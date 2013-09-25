using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("PessoasFisica")]
    public class PessoaFisica : Pessoa
    {
        [Required]
        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string OrgaoExpedidor { get; set; }

        public DateTime? DataDeNascimento { get; set; }
    }
}