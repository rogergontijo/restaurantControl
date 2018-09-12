using RestaurantControl.Domain.Entities;

namespace RestaurantControl.Domain.Interfaces.Validations
{
    public interface IBaseValidation<TEntity> where TEntity : BaseClass
    {
        bool ValidateBeforeInsert(TEntity entity);
        bool ValidateBeforeUpdate(TEntity entity);
        bool ValidateBeforeDelete(int id);
    }
}
