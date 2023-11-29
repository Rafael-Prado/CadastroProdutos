using Domain.Enuns;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Produto
    {       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public SituacaoProduto SituacaoProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public string CodigoFornecedor { get; set; }
        public string DescricaoFornecedor { get; set; }
        public string CnpjFornecedor { get; set; }

    }
}
