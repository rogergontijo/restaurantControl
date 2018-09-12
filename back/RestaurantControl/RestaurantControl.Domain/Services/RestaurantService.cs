using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Services;
using RestaurantControl.Domain.Interfaces.Validations;

namespace RestaurantControl.Domain.Services
{
    public class RestaurantService : BaseService<Restaurant>, IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantValidation _restaurantValidation;

        public RestaurantService(IRestaurantRepository restaurantRepository, IRestaurantValidation restaurantValidation)
            : base(restaurantRepository, restaurantValidation)
        {
            _restaurantRepository = restaurantRepository;
            _restaurantValidation = restaurantValidation;
        }
    }
}
