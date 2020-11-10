using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            throw new NotImplementedException();
        }
    }
}
