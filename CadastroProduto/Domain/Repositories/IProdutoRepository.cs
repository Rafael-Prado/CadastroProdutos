using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> GetProdutoPorCodigo(int codigo);
        Task<List<Produto>> GetAllProdutos(string codigoFornecedor, string CnpjFornecedor);
        Task<int> InserirProduto(Produto produto);
        Task<Produto> EditarProduto(Produto produto);
        Task<bool> ExcluirProduto(int id);
    }
}
