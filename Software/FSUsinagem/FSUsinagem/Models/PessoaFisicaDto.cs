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

        [Display(Name = "E-mail")]
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

        [Display(Name = "CEP")]
        public string EnderecoPrincipalCep { get; set; }

        [Display(Name = "Logradouro")]
        public string EnderecoPrincipalTipoDeLogradouro { get; set; }

        [Display(Name = "Endereço")]
        public string EnderecoPrincipalLogradouro { get; set; }

        [Display(Name = "Número")]
        public string EnderecoPrincipalNumero { get; set; }

        [Display(Name = "Complemento")]
        public string EnderecoPrincipalComplemento { get; set; }

        [Display(Name = "Bairro")]
        public string EnderecoPrincipalBairro { get; set; }

        [Display(Name = "Cidade")]
        public string EnderecoPrincipalMunicipio { get; set; }

        [Display(Name = "Estado")]
        public string EnderecoPrincipalUf { get; set; }

        [Display(Name = "CEP")]
        public string EnderecoCobrancaCep { get; set; }

        [Display(Name = "Logradouro")]
        public string EnderecoCobrancaTipoDeLogradouro { get; set; }

        [Display(Name = "Endereço")]
        public string EnderecoCobrancaLogradouro { get; set; }

        [Display(Name = "Número")]
        public string EnderecoCobrancaNumero { get; set; }

        [Display(Name = "Complemento")]
        public string EnderecoCobrancaComplemento { get; set; }

        [Display(Name = "Bairro")]
        public string EnderecoCobrancaBairro { get; set; }

        [Display(Name = "Cidade")]
        public string EnderecoCobrancaMunicipio { get; set; }

        [Display(Name = "Estado")]
        public string EnderecoCobrancaUf { get; set; }

        [Display(Name = "CEP")]
        public string EnderecoEntregaCep { get; set; }

        [Display(Name = "Logradouro")]
        public string EnderecoEntregaTipoDeLogradouro { get; set; }

        [Display(Name = "Endereço")]
        public string EnderecoEntregaLogradouro { get; set; }

        [Display(Name = "Número")]
        public string EnderecoEntregaNumero { get; set; }

        [Display(Name = "Complemento")]
        public string EnderecoEntregaComplemento { get; set; }

        [Display(Name = "Bairro")]
        public string EnderecoEntregaBairro { get; set; }

        [Display(Name = "Cidade")]
        public string EnderecoEntregaMunicipio { get; set; }

        [Display(Name = "Estado")]
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