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
    public class GravidadeRepository : Repository<Gravidade>, IGravidadeRepository
    {
        public GravidadeRepository(MeuDbContext context) : base(context) { }

        public async Task<Gravidade> ObterGravidade(Guid id)
        {
            return await Db.Gravidades.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Gravidade>> ObterGravidades()
        {
            return await Db.Gravidades.AsNoTracking().ToListAsync();
        }
    }
}
