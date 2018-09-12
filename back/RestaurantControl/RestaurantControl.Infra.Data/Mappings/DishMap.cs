using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantControl.Domain.Entities;

namespace RestaurantControl.Infra.Data.Mappings
{
    internal class DishMap : BaseClassMap<Dish>
    {
        public override void Configure(EntityTypeBuilder<Dish> builder)
        {
            base.Configure(builder);
            builder.ToTable("Prato");
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);

            //Foreign Key
            builder.HasOne(d => d.Restaurant).WithMany(r => r.Dishes).HasForeignKey(d => d.RestaurantId);
        }
    }
}
