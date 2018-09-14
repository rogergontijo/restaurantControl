using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Infra.Data.Mappings
{
    internal class RestaurantMap : BaseClassMap<Restaurant>
    {
        public override void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            base.Configure(builder);
            builder.ToTable("Restaurante");
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100).HasColumnName("Nome");            
        }
    }
}
