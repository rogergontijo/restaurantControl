using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Application.DTOs
{
    public class DishDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int RestaurantId { get; set; }
        public RestaurantDTO Restaurant { get; set; }
    }
}
