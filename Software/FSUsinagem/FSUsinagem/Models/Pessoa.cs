using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PessoaId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Fone { get; set; }

        public string Fax { get; set; }

        public string Celular { get; set; }

        [ForeignKey("TipoDeCadastro")]
        public int TipoDeCadastroId { get; set; }
        public virtual TipoDeCadastro TipoDeCadastro { get; set; }

        public virtual List<Endereco> Enderecos { get; set; }

        //Método
        public Endereco EnderecoPrincipal()
        {
            Endereco enderecoPrincipal;
            enderecoPrincipal = Enderecos.Find(e => e.TipoDeEndereco.Descricao == "Principal");
            if (enderecoPrincipal == null)
                enderecoPrincipal = new Endereco();
            return enderecoPrincipal;
        }

        public Endereco EnderecoCobranca()
        {
            Endereco enderecoCobranca;
            enderecoCobranca = Enderecos.Find(e => e.TipoDeEndereco.Descricao == "Cobrança");
            if (enderecoCobranca == null)
                enderecoCobranca = new Endereco();
            return enderecoCobranca;
        }

        public Endereco EnderecoEntrega()
        {
            Endereco enderecoEntrega;
            enderecoEntrega = Enderecos.Find(e => e.TipoDeEndereco.Descricao == "Entrega");
            if (enderecoEntrega == null)
                enderecoEntrega = new Endereco();
            return enderecoEntrega;
        }
    }
}