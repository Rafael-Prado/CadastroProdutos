using Dapper;
using Domain.Entities;
using Domain.Repositories;
using Infra.Context;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _context;
        private IConfiguration _config;

        public ProdutoRepository(ProdutoContext context, IConfiguration configuration)
        {
            _context = context;
            _config = configuration;
        }

        public async Task<Produto> EditarProduto(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
            return produto;
        }

        public Task<bool> ExcluirProduto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produto>> GetAllProdutos(string codigoFornecedor, string CnpjFornecedor)
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("CnnStr")))
            {
                return conexao.ExecuteScalar<List<Produto>>(
                @$"");
            }
        }

        public async Task<Produto> GetProdutoPorCodigo(int codigo)
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("CnnStr")))
            {
                return conexao.ExecuteScalar<Produto>(
                @$"");
            }
        }

        public async Task<int> InserirProduto(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
            return produto.Id;
        }
    }
}
