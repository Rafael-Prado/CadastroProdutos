using Domain.Entities;
using Domain.Repositories;
using Domain.Servicies.Interface;
using Domain.Validator;
using FluentValidation.Results;

namespace Domain.Servicies
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        private readonly ProdutoValidator _validator;

        public ProdutoService(IProdutoRepository repository, ProdutoValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<ValidationResult> EditarProduto(Produto produto)
        {
            var result = _validator.Validate(produto);
            if (!result.IsValid)
            {
                return result;
            }
            _repository.InserirProduto(produto);
            return result;
        }

        public Task<bool> ExcluirProduto(int id)
        {
            return _repository.ExcluirProduto(id);
        }

        public Task<List<Produto>> GetAllProdutos(string codigoFornecedor, string CnpjFornecedor)
        {
            return _repository.GetAllProdutos(codigoFornecedor, CnpjFornecedor);
        }

        public Task<Produto> GetProdutoPorCodigo(int codigo)
        {
            return _repository.GetProdutoPorCodigo(codigo);
        }

        public async Task<ValidationResult> InserirProduto(Produto produto)
        {
            var result =  _validator.Validate(produto);
            if (!result.IsValid)
            {
                return result;
            }
            var teste =  _repository.InserirProduto(produto);
            return result;
        }

    }
}
