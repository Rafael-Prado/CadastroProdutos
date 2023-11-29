using Domain.Entities;
using FluentValidation;

namespace Domain.Validator
{
    public  class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(produto => produto.DescricaoProduto).NotNull().WithMessage(produto => $" {produto.DescricaoProduto} não pode se vazia ou nula!");
            RuleFor(produto => produto.CodigoProduto).NotNull().WithMessage(produto => $" {produto.CodigoProduto} não pode se vazia ou nula!");
            RuleFor(produto => produto.DataFabricacao >= produto.DataValidade).Equal(true).WithMessage(produto => $" {produto.DataFabricacao} Menor que  {produto.DataValidade}!");
        }
    }
}
