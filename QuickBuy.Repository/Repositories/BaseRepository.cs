﻿using System.Collections.Generic;
using System.Linq;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContext QuickBuyContext;

    
        public BaseRepository (QuickBuyContext quickBuyContext)
        {
            QuickBuyContext = quickBuyContext;
        }

        public void Add(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();

        }

        public void delete(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Remove(entity);
            QuickBuyContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return QuickBuyContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return QuickBuyContext.Set<TEntity>().Find(id);
        }

        public void update(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }

        public void Dispose()
        {
            QuickBuyContext.Dispose();
        }
    }
}
