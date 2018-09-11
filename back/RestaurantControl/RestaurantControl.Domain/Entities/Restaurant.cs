using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Domain.Entities
{
    public class Restaurant : BaseClass
    {
        public string RazaoSocial { get; set; }

        public ICollection<Dish> Dishes { get; set; }

        public Restaurant()
        {
            this.Dishes = new List<Dish>();
        }
    }
}
