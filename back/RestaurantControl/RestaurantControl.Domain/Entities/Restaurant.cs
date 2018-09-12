using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Domain.Entities
{
    public class Restaurant : BaseClass
    {
        public string Nome { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }

        public Restaurant()
        {
            this.Dishes = new List<Dish>();
        }
    }
}
