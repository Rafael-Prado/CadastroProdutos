using Domain.Enuns;

namespace Application.Model
{
    public class ProdutoModel
    {
       
        public int Id { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public SituacaoProduto SituacaoProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public string CodigoFornecedor { get; set; }
        public string DecricaoFornecedor { get; set; }
        public string CnpjFornecedor { get; set; }
    }
}
