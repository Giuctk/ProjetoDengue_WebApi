using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class AtendimentoMapping : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.DataInclusao);
            
            builder.Property(x => x.ObservacaoRequisitante);
            
            builder.Property(x => x.IdGravidade);
            
            builder.Property(x => x.DataAtendimento);
            
            builder.Property(x => x.DataAtualizacao);
            
            builder.Property(x => x.IdStatus);
            
            builder.Property(x => x.IdRequisitante);
            
            builder.Property(x => x.IdAgenteAdministrativo);
            
            builder.Property(x => x.IdAgenteCampo);
        }
    }
}
