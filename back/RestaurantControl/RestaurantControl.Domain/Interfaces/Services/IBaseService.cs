using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity>
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetByName(string name);
        void Dispose();
    }
}
