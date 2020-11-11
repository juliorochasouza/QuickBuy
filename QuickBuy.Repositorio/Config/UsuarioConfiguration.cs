using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            // Builder utiliza o padrão Fluent com lambda
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            // Configura 1 para muitos
            // um usuario para varios pedidos
            // Core reconhece e ja faz o mapeamento
            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario)
        }
    }
}
