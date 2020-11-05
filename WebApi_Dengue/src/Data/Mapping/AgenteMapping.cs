using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class AgenteMapping : IEntityTypeConfiguration<Agente>
    {
        public void Configure(EntityTypeBuilder<Agente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Nome);

            builder.Property(x => x.Email);

            builder.Property(x => x.UserName);

            builder.Property(x => x.Senha)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .IsRequired();
        }
    }
}
