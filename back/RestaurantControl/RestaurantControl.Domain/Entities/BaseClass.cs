using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Domain.Entities
{
    public class BaseClass
    {
        public int Id { get; set; }
        public DateTime DataHoraCadastro { get; set; }

        public BaseClass()
        {
            this.DataHoraCadastro = DateTime.Now;
        }
    }
}
