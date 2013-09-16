using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    public class PessoaFisicaDto
    {
        public PessoaFisicaDto() { }
        //Construtor
        public PessoaFisicaDto(PessoaFisica pessoaFisica)
        {
            PessoaId = pessoaFisica.PessoaId;
            Cpf = pessoaFisica.Cpf;
            Nome = pessoaFisica.Nome;
            Email = pessoaFisica.Email;
            Fone = pessoaFisica.Fone;
            Fax = pessoaFisica.Fax;
            Celular = pessoaFisica.Celular;
            Rg = pessoaFisica.Rg;
            OrgaoExpedidor = pessoaFisica.OrgaoExpedidor;
            DataDeNascimento = pessoaFisica.DataDeNascimento;
            TipoDeCadastroId = pessoaFisica.TipoDeCadastroId;

            Endereco enderecoPrincipal = pessoaFisica.EnderecoPrincipal();
            EnderecoPrincipalCep = enderecoPrincipal.Cep;
            EnderecoPrincipalTipoDeLogradouro = enderecoPrincipal.TipoDeLogradouro;
            EnderecoPrincipalLogradouro = enderecoPrincipal.Logradouro;
            EnderecoPrincipalNumero = enderecoPrincipal.Numero;
            EnderecoPrincipalComplemento = enderecoPrincipal.Complemento;
            EnderecoPrincipalBairro = enderecoPrincipal.Bairro;
            EnderecoPrincipalMunicipio = enderecoPrincipal.Municipio;
            EnderecoPrincipalUf = enderecoPrincipal.Uf;

            Endereco enderecoCobranca = pessoaFisica.EnderecoCobranca();
            EnderecoCobrancaCep = enderecoCobranca.Cep;
            EnderecoCobrancaTipoDeLogradouro = enderecoCobranca.TipoDeLogradouro;
            EnderecoCobrancaLogradouro = enderecoCobranca.Logradouro;
            EnderecoCobrancaNumero = enderecoCobranca.Numero;
            EnderecoCobrancaComplemento = enderecoCobranca.Complemento;
            EnderecoCobrancaBairro = enderecoCobranca.Bairro;
            EnderecoCobrancaMunicipio = enderecoCobranca.Municipio;
            EnderecoCobrancaUf = enderecoCobranca.Uf;

            Endereco enderecoEntrega = pessoaFisica.EnderecoEntrega();
            EnderecoEntregaCep = enderecoEntrega.Cep;
            EnderecoEntregaTipoDeLogradouro = enderecoEntrega.TipoDeLogradouro;
            EnderecoEntregaLogradouro = enderecoEntrega.Logradouro;
            EnderecoEntregaNumero = enderecoEntrega.Numero;
            EnderecoEntregaComplemento = enderecoEntrega.Complemento;
            EnderecoEntregaBairro = enderecoEntrega.Bairro;
            EnderecoEntregaMunicipio = enderecoEntrega.Municipio;
            EnderecoEntregaUf = enderecoEntrega.Uf;
        }

        [Key]
        public int PessoaId { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Fone { get; set; }

        public string Fax { get; set; }

        public string Celular { get; set; }

        public int TipoDeCadastroId { get; set; }
        //public virtual TipoDeCadastro TipoDeCadastro { get; set; }

        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "Orgão Expedidor")]
        public string OrgaoExpedidor { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime? DataDeNascimento { get; set; }

        public string EnderecoPrincipalCep { get; set; }

        public string EnderecoPrincipalTipoDeLogradouro { get; set; }

        public string EnderecoPrincipalLogradouro { get; set; }

        public string EnderecoPrincipalNumero { get; set; }

        public string EnderecoPrincipalComplemento { get; set; }

        public string EnderecoPrincipalBairro { get; set; }

        public string EnderecoPrincipalMunicipio { get; set; }

        public string EnderecoPrincipalUf { get; set; }

        public string EnderecoCobrancaCep { get; set; }

        public string EnderecoCobrancaTipoDeLogradouro { get; set; }

        public string EnderecoCobrancaLogradouro { get; set; }

        public string EnderecoCobrancaNumero { get; set; }

        public string EnderecoCobrancaComplemento { get; set; }

        public string EnderecoCobrancaBairro { get; set; }

        public string EnderecoCobrancaMunicipio { get; set; }

        public string EnderecoCobrancaUf { get; set; }

        public string EnderecoEntregaCep { get; set; }

        public string EnderecoEntregaTipoDeLogradouro { get; set; }

        public string EnderecoEntregaLogradouro { get; set; }

        public string EnderecoEntregaNumero { get; set; }

        public string EnderecoEntregaComplemento { get; set; }

        public string EnderecoEntregaBairro { get; set; }

        public string EnderecoEntregaMunicipio { get; set; }

        public string EnderecoEntregaUf { get; set; }

        public void AssignTo(PessoaFisica pessoaFisica)
        {
            pessoaFisica.PessoaId = PessoaId;
            pessoaFisica.Cpf = Cpf;
            pessoaFisica.Nome = Nome;
            pessoaFisica.Email = Email;
            pessoaFisica.Fone = Fone;
            pessoaFisica.Fax = Fax;
            pessoaFisica.Celular = Celular;
            pessoaFisica.Rg = Rg;
            pessoaFisica.OrgaoExpedidor = OrgaoExpedidor;
            pessoaFisica.DataDeNascimento = DataDeNascimento;
            pessoaFisica.TipoDeCadastroId = TipoDeCadastroId;

            Endereco enderecoPrincipal = pessoaFisica.EnderecoPrincipal();
            enderecoPrincipal.Cep = EnderecoPrincipalCep;
            enderecoPrincipal.TipoDeLogradouro = EnderecoPrincipalTipoDeLogradouro;
            enderecoPrincipal.Logradouro = EnderecoPrincipalLogradouro;
            enderecoPrincipal.Numero = EnderecoPrincipalNumero;
            enderecoPrincipal.Complemento = EnderecoPrincipalComplemento;
            enderecoPrincipal.Bairro = EnderecoPrincipalBairro;
            enderecoPrincipal.Municipio = EnderecoPrincipalMunicipio;
            enderecoPrincipal.Uf = EnderecoPrincipalUf;

            Endereco enderecoCobranca = pessoaFisica.EnderecoCobranca();
            enderecoCobranca.Cep = EnderecoCobrancaCep;
            enderecoCobranca.TipoDeLogradouro = EnderecoCobrancaTipoDeLogradouro;
            enderecoCobranca.Logradouro = EnderecoCobrancaLogradouro;
            enderecoCobranca.Numero = EnderecoCobrancaNumero;
            enderecoCobranca.Complemento = EnderecoCobrancaComplemento;
            enderecoCobranca.Bairro = EnderecoCobrancaBairro;
            enderecoCobranca.Municipio = EnderecoCobrancaMunicipio;
            enderecoCobranca.Uf = EnderecoCobrancaUf;

            Endereco enderecoEntrega = pessoaFisica.EnderecoEntrega();
            enderecoEntrega.Cep = EnderecoEntregaCep;
            enderecoEntrega.TipoDeLogradouro = EnderecoEntregaTipoDeLogradouro;
            enderecoEntrega.Logradouro = EnderecoEntregaLogradouro;
            enderecoEntrega.Numero = EnderecoEntregaNumero;
            enderecoEntrega.Complemento = EnderecoEntregaComplemento;
            enderecoEntrega.Bairro = EnderecoEntregaBairro;
            enderecoEntrega.Municipio = EnderecoEntregaMunicipio;
            enderecoEntrega.Uf = EnderecoEntregaUf;
        }

        public PessoaFisica ToEntity()
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            AssignTo(pessoaFisica);
            return pessoaFisica;
        }
    }
}