﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EnderecoId { get; set; }

        public string Cep { get; set; }

        public string TipoDeLogradouro { get; set; }

        public string Logradouro { get; set; }
        
        public string Numero { get; set; }

        public string Complemento { get; set; }
        
        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string Uf { get; set; }
        
        [ForeignKey("TipoDeEndereco")]
        public int TipoDeEnderecoId { get; set; }
        public virtual TipoDeEndereco TipoDeEndereco { get; set; }
    }
}