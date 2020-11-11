using Business.Interfaces.Repository;
using Business.Model;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class LocalizacaoRepository : RepositoryBase<Localizacao>, ILocalizacaoRepository
    {
        public LocalizacaoRepository(MeuDbContext dbContext) : base(dbContext) { }
    }
}
