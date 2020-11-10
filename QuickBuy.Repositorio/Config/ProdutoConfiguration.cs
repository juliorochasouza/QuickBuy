using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Descricao)
                .HasMaxLength(400)
                .IsRequired();

            builder
                .Property(p => p.Preco)
                .IsRequired();
        }
    }
}
