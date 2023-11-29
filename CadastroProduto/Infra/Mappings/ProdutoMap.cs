
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.CodigoProduto)
                .IsRequired();
            builder.Property(p => p.DescricaoProduto)
               .IsRequired();
            builder.Property(p => p.SituacaoProduto)
               .IsRequired();
            builder.Property(p => p.DataFabricacao);

            builder.Property(p => p.DataValidade);

            builder.Property(p => p.CodigoFornecedor);

            builder.Property(p => p.DescricaoFornecedor);
            
            builder.Property(p => p.CnpjFornecedor);

        }
    }
}
