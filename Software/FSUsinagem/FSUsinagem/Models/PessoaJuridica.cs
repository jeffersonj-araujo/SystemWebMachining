using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("PessoasJuridica")]
    public class PessoaJuridica : Pessoa
    {
        [Required]
        public string Cnpj { get; set; }

        public string Contato { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string InscricaoEstadual { get; set; }
    }
}