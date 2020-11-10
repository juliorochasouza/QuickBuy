using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
