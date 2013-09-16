using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FSUsinagem.Models
{
    [Table("TiposDeEndereco")]
    public class TipoDeEndereco
    {
        public TipoDeEndereco() { }

        public TipoDeEndereco(TipoDeEndereco tipoDeEndereco)
        {
            TipoDeEnderecoId = tipoDeEndereco.TipoDeEnderecoId;
            Descricao = tipoDeEndereco.Descricao;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int TipoDeEnderecoId { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual List<Endereco> Enderecos { get; set; }

        static public TipoDeEndereco TipoDeEnderecoPrincipal = new TipoDeEndereco
        {
            TipoDeEnderecoId = 1,
            Descricao = "Principal"
        };

        static public TipoDeEndereco TipoDeEnderecoCobranca = new TipoDeEndereco
        {
            TipoDeEnderecoId = 2,
            Descricao = "Cobrança"
        };

        static public TipoDeEndereco TipoDeEnderecoEntrega = new TipoDeEndereco
        {
            TipoDeEnderecoId = 3,
            Descricao = "Entrega"
        };
    }
}