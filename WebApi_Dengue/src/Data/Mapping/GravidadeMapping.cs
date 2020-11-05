using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class GravidadeMapping : IEntityTypeConfiguration<Gravidade>
    {
        public void Configure(EntityTypeBuilder<Gravidade> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired();

            builder.Property(x => x.Prioridade)
                .IsRequired();
        }
    }
}
