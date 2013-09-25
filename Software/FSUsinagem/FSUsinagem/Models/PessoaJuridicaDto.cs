using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    public class PessoaJuridicaDto
    {
        public PessoaJuridicaDto() { }
        //Construtor
        public PessoaJuridicaDto(PessoaJuridica pessoaJuridica)
        {
            PessoaId = pessoaJuridica.PessoaId;
            Cnpj = pessoaJuridica.Cnpj;
            Nome = pessoaJuridica.Nome;
            Email = pessoaJuridica.Email;
            Fone = pessoaJuridica.Fone;
            Fax = pessoaJuridica.Fax;
            Celular = pessoaJuridica.Celular;
            Contato = pessoaJuridica.Contato;
            InscricaoMunicipal = pessoaJuridica.InscricaoMunicipal;
            InscricaoEstadual = pessoaJuridica.InscricaoEstadual;
            TipoDeCadastroId = pessoaJuridica.TipoDeCadastroId;

            Endereco enderecoPrincipal = pessoaJuridica.EnderecoPrincipal();
            EnderecoPrincipalCep = enderecoPrincipal.Cep;
            EnderecoPrincipalTipoDeLogradouro = enderecoPrincipal.TipoDeLogradouro;
            EnderecoPrincipalLogradouro = enderecoPrincipal.Logradouro;
            EnderecoPrincipalNumero = enderecoPrincipal.Numero;
            EnderecoPrincipalComplemento = enderecoPrincipal.Complemento;
            EnderecoPrincipalBairro = enderecoPrincipal.Bairro;
            EnderecoPrincipalMunicipio = enderecoPrincipal.Municipio;
            EnderecoPrincipalUf = enderecoPrincipal.Uf;

            Endereco enderecoCobranca = pessoaJuridica.EnderecoCobranca();
            EnderecoCobrancaCep = enderecoCobranca.Cep;
            EnderecoCobrancaTipoDeLogradouro = enderecoCobranca.TipoDeLogradouro;
            EnderecoCobrancaLogradouro = enderecoCobranca.Logradouro;
            EnderecoCobrancaNumero = enderecoCobranca.Numero;
            EnderecoCobrancaComplemento = enderecoCobranca.Complemento;
            EnderecoCobrancaBairro = enderecoCobranca.Bairro;
            EnderecoCobrancaMunicipio = enderecoCobranca.Municipio;
            EnderecoCobrancaUf = enderecoCobranca.Uf;

            Endereco enderecoEntrega = pessoaJuridica.EnderecoEntrega();
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
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Required]
        [Display(Name = "Razão Social")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public string Fone { get; set; }

        public string Fax { get; set; }

        public string Celular { get; set; }

        public int TipoDeCadastroId { get; set; }

        [Display(Name = "Contato")]
        public string Contato { get; set; }

        [Display(Name = "Inscricão Municipal")]
        public string InscricaoMunicipal { get; set; }

        [Display(Name = "Inscricão Estadual")]
        public string InscricaoEstadual { get; set; }

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

        public void AssignTo(PessoaJuridica pessoaJuridica)
        {
            pessoaJuridica.PessoaId = PessoaId;
            pessoaJuridica.Cnpj = Cnpj;
            pessoaJuridica.Nome = Nome;
            pessoaJuridica.Email = Email;
            pessoaJuridica.Fone = Fone;
            pessoaJuridica.Fax = Fax;
            pessoaJuridica.Celular = Celular;
            pessoaJuridica.Contato = Contato;
            pessoaJuridica.InscricaoMunicipal = InscricaoMunicipal;
            pessoaJuridica.InscricaoEstadual = InscricaoEstadual;
            pessoaJuridica.TipoDeCadastroId = TipoDeCadastroId;

            Endereco enderecoPrincipal = pessoaJuridica.EnderecoPrincipal();
            enderecoPrincipal.Cep = EnderecoPrincipalCep;
            enderecoPrincipal.TipoDeLogradouro = EnderecoPrincipalTipoDeLogradouro;
            enderecoPrincipal.Logradouro = EnderecoPrincipalLogradouro;
            enderecoPrincipal.Numero = EnderecoPrincipalNumero;
            enderecoPrincipal.Complemento = EnderecoPrincipalComplemento;
            enderecoPrincipal.Bairro = EnderecoPrincipalBairro;
            enderecoPrincipal.Municipio = EnderecoPrincipalMunicipio;
            enderecoPrincipal.Uf = EnderecoPrincipalUf;

            Endereco enderecoCobranca = pessoaJuridica.EnderecoCobranca();
            enderecoCobranca.Cep = EnderecoCobrancaCep;
            enderecoCobranca.TipoDeLogradouro = EnderecoCobrancaTipoDeLogradouro;
            enderecoCobranca.Logradouro = EnderecoCobrancaLogradouro;
            enderecoCobranca.Numero = EnderecoCobrancaNumero;
            enderecoCobranca.Complemento = EnderecoCobrancaComplemento;
            enderecoCobranca.Bairro = EnderecoCobrancaBairro;
            enderecoCobranca.Municipio = EnderecoCobrancaMunicipio;
            enderecoCobranca.Uf = EnderecoCobrancaUf;

            Endereco enderecoEntrega = pessoaJuridica.EnderecoEntrega();
            enderecoEntrega.Cep = EnderecoEntregaCep;
            enderecoEntrega.TipoDeLogradouro = EnderecoEntregaTipoDeLogradouro;
            enderecoEntrega.Logradouro = EnderecoEntregaLogradouro;
            enderecoEntrega.Numero = EnderecoEntregaNumero;
            enderecoEntrega.Complemento = EnderecoEntregaComplemento;
            enderecoEntrega.Bairro = EnderecoEntregaBairro;
            enderecoEntrega.Municipio = EnderecoEntregaMunicipio;
            enderecoEntrega.Uf = EnderecoEntregaUf;
        }

        public PessoaJuridica ToEntity()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            AssignTo(pessoaJuridica);
            return pessoaJuridica;
        }
    }
}