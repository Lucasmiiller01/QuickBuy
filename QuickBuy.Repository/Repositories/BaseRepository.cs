using System.Collections.Generic;
using QuickBuy.Domain.Contracts;


namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository ()
        {

        }

        public void Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
