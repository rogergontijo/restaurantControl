using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Infra.Data.Mappings
{
    internal class DishMap : BaseClassMap<Dish>
    {
        public override void Configure(EntityTypeBuilder<Dish> builder)
        {
            base.Configure(builder);
            //builder.ToTable("Prato");
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
        }
    }
}
