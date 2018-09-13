using RestaurantControl.Application.DTOs;
using RestaurantControl.Application.Interfaces;
using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Services;

namespace RestaurantControl.Application.Services
{
    public class AppDishService : AppBaseService<Dish, DishDTO>, IAppDishService
    {
        private readonly IDishService _service;

        public AppDishService(IDishService service)
            : base(service)
        {
            _service = service;
        }
    }
}
