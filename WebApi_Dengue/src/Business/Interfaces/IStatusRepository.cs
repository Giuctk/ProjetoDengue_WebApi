using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Models;

namespace Business.Interfaces
{
    public interface IStatusRepository : IRepository<Status>
    {
        Task<IEnumerable<Status>> ObterStatus();
        Task<Status> ObterStatus(Guid id);
    }
}
