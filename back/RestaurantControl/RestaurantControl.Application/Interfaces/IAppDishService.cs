using RestaurantControl.Application.DTOs;
using RestaurantControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Application.Interfaces
{
    public interface IAppDishService : IAppBaseService<Dish, DishDTO>
    {
    }
}
