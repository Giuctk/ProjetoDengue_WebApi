using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class AtendimentoRepository : Repository<Atendimento>, IAtendimentoRepository
    {
        public AtendimentoRepository(MeuDbContext context) : base(context) { }

        public async Task<Atendimento> ObterAtendimento(Guid id)
        {
            return await Db.Atendimentos.AsNoTracking()
                .Include(x => x.AgenteAdministrativo)
                .Include(x => x.AgenteCampo)
                .Include(x => x.Status)
                .Include(x => x.Gravidade)
                .Include(x => x.Localizacao)
                .Include(x => x.Requisitante)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Atendimento>> ObterAtendimentos()
        {
            return await Db.Atendimentos.AsNoTracking()
                .Include(x => x.AgenteAdministrativo)
                .Include(x => x.AgenteCampo)
                .Include(x => x.Status)
                .Include(x => x.Gravidade)
                .Include(x => x.Localizacao)
                .Include(x => x.Requisitante)
                .ToListAsync();
        }

        public async Task<IEnumerable<Atendimento>> ObterAtendimentosPorAgenteAdmin(Guid idAgenteAdmin)
        {
            return await Db.Atendimentos.AsNoTracking()
                .Include(x => x.AgenteAdministrativo)
                .Include(x => x.AgenteCampo)
                .Include(x => x.Status)
                .Include(x => x.Gravidade)
                .Include(x => x.Localizacao)
                .Include(x => x.Requisitante)
                .Where(x => x.IdAgenteAdministrativo.HasValue && x.IdAgenteAdministrativo.Value == idAgenteAdmin)
                .ToListAsync();
        }

        public async Task<IEnumerable<Atendimento>> ObterAtendimentosPorAgenteCampo(Guid idAgenteCampo)
        {
            return await Db.Atendimentos.AsNoTracking()
                .Include(x => x.AgenteAdministrativo)
                .Include(x => x.AgenteCampo)
                .Include(x => x.Status)
                .Include(x => x.Gravidade)
                .Include(x => x.Localizacao)
                .Include(x => x.Requisitante)
                .Where(x => x.IdAgenteAdministrativo.HasValue && x.IdAgenteAdministrativo.Value == idAgenteCampo)
                .ToListAsync();
        }
    }
}
