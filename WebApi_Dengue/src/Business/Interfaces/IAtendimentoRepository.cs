using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Models;

namespace Business.Interfaces
{
    public interface IAtendimentoRepository : IRepository<Atendimento>
    {
        Task<IEnumerable<Atendimento>> ObterAtendimentosPorAgenteCampo(Guid agenteCampoId);
        Task<IEnumerable<Atendimento>> ObterAtendimentosPorAgenteAdmin(Guid agenteAdminId);
        Task<IEnumerable<Atendimento>> ObterAtendimentos();
        Task<Atendimento> ObterAtendimento(Guid id);
    }
}
