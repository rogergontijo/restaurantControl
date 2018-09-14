using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Services;
using RestaurantControl.Domain.Interfaces.Validations;
using System;
using System.Collections.Generic;

namespace RestaurantControl.Domain.Services
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity>
        where TEntity : BaseClass
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IBaseValidation<TEntity> _validator;

        public BaseService(IBaseRepository<TEntity> repository, IBaseValidation<TEntity> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public TEntity Insert(TEntity entity)
        {            
            var isValid = _validator.ValidateBeforeInsert(entity);
            if (isValid)
            {
                _repository.Insert(entity);
            }

            return entity;
        }

        public void Update(TEntity entity)
        {
            var isValid = _validator.ValidateBeforeUpdate(entity);
            if (isValid)
            {
                _repository.Update(entity);
            }
        }

        public void Delete(int id)
        {
            var isValid = _validator.ValidateBeforeDelete(id);
            if (isValid)
            {
                _repository.Delete(id);
            }
        }        

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }              

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
