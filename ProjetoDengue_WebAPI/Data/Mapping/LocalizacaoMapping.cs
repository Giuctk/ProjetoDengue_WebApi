using Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class LocalizacaoMapping : IEntityTypeConfiguration<Localizacao>
    {
        public void Configure(EntityTypeBuilder<Localizacao> builder)
        {
            builder.ToTable("Localizacao");

            builder.HasKey(p => p.IdLocalizacao);

            builder.Property(c => c.CEP)
                .HasColumnType("varchar(10)");

            builder.Property(c => c.Rua)
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Numero)
                .HasColumnType("varchar(10)");

            builder.Property(c => c.Bairro)
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Cidade)
                .HasColumnType("varchar(100)");

            builder.Property(c => c.SiglaEstado)
                .HasColumnType("varchar(2)");
        }
    }
}
