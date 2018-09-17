using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantControl.Infra.Data.Repositories
{
    public class DishRepository : BaseRepository<Dish>, IDishRepository
    {
        public DishRepository(ContextDb context)
            : base(context)
        {
        }

        public override IEnumerable<Dish> GetAll()
        {
            return _context.Dishes.Include(p => p.Restaurant).ToList();
        }
    }
}
