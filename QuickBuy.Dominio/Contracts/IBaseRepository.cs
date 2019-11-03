using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void update(TEntity entity);

        void delete(TEntity entity);

    }
}
