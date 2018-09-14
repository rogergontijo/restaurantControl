using RestaurantControl.Domain.Entities;
using System.Collections.Generic;

namespace RestaurantControl.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseClass
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();        
        void Dispose();
    }
}
