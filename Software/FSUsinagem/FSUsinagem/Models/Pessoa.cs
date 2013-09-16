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

        private List<Endereco> EnderecosValido()
        {
            if (Enderecos == null)
                Enderecos = new List<Endereco>();
            return Enderecos;
        }

        //Método
        public Endereco EnderecoPrincipal()
        {
            Endereco enderecoPrincipal;
            enderecoPrincipal = EnderecosValido().Find(e => e.TipoDeEnderecoId == TipoDeEndereco.TipoDeEnderecoPrincipal.TipoDeEnderecoId);
            if (enderecoPrincipal == null)
            {
                enderecoPrincipal = new Endereco();
                enderecoPrincipal.TipoDeEnderecoId = TipoDeEndereco.TipoDeEnderecoPrincipal.TipoDeEnderecoId;
                Enderecos.Add(enderecoPrincipal);
            }
            return enderecoPrincipal;
        }

        public Endereco EnderecoCobranca()
        {
            Endereco enderecoCobranca;
            enderecoCobranca = EnderecosValido().Find(e => e.TipoDeEnderecoId == TipoDeEndereco.TipoDeEnderecoCobranca.TipoDeEnderecoId);
            if (enderecoCobranca == null)
            {
                enderecoCobranca = new Endereco();
                enderecoCobranca.TipoDeEnderecoId = TipoDeEndereco.TipoDeEnderecoCobranca.TipoDeEnderecoId;
                Enderecos.Add(enderecoCobranca);
            }
            return enderecoCobranca;
        }

        public Endereco EnderecoEntrega()
        {
            Endereco enderecoEntrega;
            enderecoEntrega = EnderecosValido().Find(e => e.TipoDeEnderecoId == TipoDeEndereco.TipoDeEnderecoEntrega.TipoDeEnderecoId);
            if (enderecoEntrega == null)
            {
                enderecoEntrega = new Endereco();
                enderecoEntrega.TipoDeEnderecoId = TipoDeEndereco.TipoDeEnderecoEntrega.TipoDeEnderecoId;
                Enderecos.Add(enderecoEntrega);
            }
            return enderecoEntrega;
        }
    }
}