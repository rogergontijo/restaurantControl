using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Infra.Data.Repositories
{
    public class DishRepository : BaseRepository<Dish>, IDishRepository
    {
        public DishRepository(ContextDb context)
            : base(context)
        {
        }
    }
}
