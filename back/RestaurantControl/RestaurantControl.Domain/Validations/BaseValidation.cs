using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Validations;
using System;

namespace RestaurantControl.Domain.Validations
{
    public class BaseValidation<TEntity> : IBaseValidation<TEntity>
        where TEntity : BaseClass
    {

        private readonly IBaseRepository<TEntity> _repository;

        public BaseValidation(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public bool ValidateBeforeDelete(int id)
        {
            if (id == 0)
            {
                throw new Exception("Id deve conter um valor válido.");
            }

            var entity = _repository.GetById(id);
            return Validate(entity);
        }

        public bool ValidateBeforeInsert(TEntity entity)
        {
            return Validate(entity);
        }

        public bool ValidateBeforeUpdate(TEntity entity)
        {
            if (entity.Id == 0)
            {
                throw new Exception("Entidade inexistente.");
            }

            return Validate(entity);
        }

        protected virtual bool Validate(TEntity entity)
        {
            if (entity == null)
            {
                throw new Exception("Entidade não pode ser nula.");
            }

            return true;
        }
    }
}
