using Business.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class AtendimentoMapping : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.ToTable("Atendimento");

            builder.HasKey(p => p.IdAtendimento);

            builder.Property(c => c.ObservacaoRequisitante)
                .HasColumnType("varchar(3000)");

            builder.Property(c => c.ObservacaoAgente)
                .HasColumnType("varchar(3000)");

            builder.HasOne(x => x.Localizacao)
                .WithMany(x => x.Atendimentos)
                .HasForeignKey(x => x.IdLocalizacao);

            builder.HasOne(x => x.Gravidade)
                .WithMany(x => x.Atendimentos)
                .HasForeignKey(x => x.IdGravidade);

            builder.HasOne(x => x.Status)
                .WithMany(x => x.Atendimentos)
                .HasForeignKey(x => x.IdStatus);

            builder.HasOne(x => x.AgenteAdministrativo)
                .WithMany(x => x.AtendimentosAdm)
                .HasForeignKey(x => x.IdAgenteAdministrativo);

            builder.HasOne(x => x.AgenteCampo)
                .WithMany(x => x.AtendimentosCampo)
                .HasForeignKey(x => x.IdAgenteCampo);
        }
    }
}
