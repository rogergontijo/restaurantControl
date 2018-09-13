using RestaurantControl.Application.DTOs;
using RestaurantControl.Application.Interfaces;
using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Services;

namespace RestaurantControl.Application.Services
{
    public class AppRestaurantService : AppBaseService<Restaurant, RestaurantDTO>, IAppRestaurantService
    {
        private readonly IRestaurantService _service;

        public AppRestaurantService(IRestaurantService service)
            : base(service)
        {
            _service = service;
        }
    }
}
