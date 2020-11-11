using Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(p => p.IdUsuario);

            builder.Property(c => c.UserName)
                .HasColumnType("varchar(10)");

            builder.Property(c => c.Senha)
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Email)
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Telefone)
                .HasColumnType("varchar(50)");
        }
    }
}
