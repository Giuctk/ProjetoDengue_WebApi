using Business.Interfaces.Repository;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity: class
    {
        protected readonly MeuDbContext _dbContext;
        public RepositoryBase(MeuDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            _dbContext.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            _dbContext.Entry(entity).State = EntityState.Detached;
            return entity;
        }
    }
}
