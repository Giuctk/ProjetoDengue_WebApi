using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Models;

namespace Business.Interfaces
{
    public interface IGravidadeRepository : IRepository<Gravidade>
    {
        Task<IEnumerable<Gravidade>> ObterGravidades();
        Task<Gravidade> ObterGravidade(Guid id);
    }
}
