using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Services;
using RestaurantControl.Domain.Interfaces.Validations;

namespace RestaurantControl.Domain.Services
{
    public class DishService : BaseService<Dish>, IDishService
    {
        private readonly IDishRepository _dishRepository;
        private readonly IDishValidation _dishValidation;

        public DishService(IDishRepository dishRepository, IDishValidation dishValidation)
            : base (dishRepository, dishValidation)
        {
            _dishRepository = dishRepository;
            _dishValidation = dishValidation;
        }
    }
}
