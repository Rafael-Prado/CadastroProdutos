using Domain.Entities;
using FluentValidation.Results;

namespace Domain.Servicies.Interface
{
    public  interface IProdutoService
    {
        Task<Produto> GetProdutoPorCodigo(int codigo);
        Task<List<Produto>> GetAllProdutos(string codigoFornecedor, string CnpjFornecedor);
        Task<ValidationResult> InserirProduto(Produto produto);
        Task<ValidationResult> EditarProduto(Produto produto);
        Task<bool> ExcluirProduto(int id);
    }
}
