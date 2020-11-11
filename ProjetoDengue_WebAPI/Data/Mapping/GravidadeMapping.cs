using Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class GravidadeMapping : IEntityTypeConfiguration<Gravidade>
    {
        public void Configure(EntityTypeBuilder<Gravidade> builder)
        {
            builder.ToTable("Gravidade");

            builder.HasKey(p => p.IdGravidade);

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(30)");
        }
    }
}
