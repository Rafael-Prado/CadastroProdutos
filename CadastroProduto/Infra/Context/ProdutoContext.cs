using Domain.Entities;
using Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public  class ProdutoContext :DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options)
        : base(options)
        { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());

        }
    }
}
