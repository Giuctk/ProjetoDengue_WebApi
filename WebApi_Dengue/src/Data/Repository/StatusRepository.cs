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
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        public StatusRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<Status>> ObterStatus()
        {
            return await Db.Status.AsNoTracking().ToListAsync();
        }

        public async Task<Status> ObterStatus(Guid id)
        {
            return await Db.Status.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
