using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class LocalizacaoMapping : IEntityTypeConfiguration<Localizacao>
    {
        public void Configure(EntityTypeBuilder<Localizacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Endereco);

            builder.Property(x => x.Bairro);

            builder.Property(x => x.CEP);

            builder.Property(x => x.Latitude);

            builder.Property(x => x.Longitude);
        }
    }
}
