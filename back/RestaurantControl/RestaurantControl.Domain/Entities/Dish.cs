using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Domain.Entities
{
    public class Dish : BaseClass
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
