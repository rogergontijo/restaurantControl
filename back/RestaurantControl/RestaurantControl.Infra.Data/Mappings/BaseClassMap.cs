using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Infra.Data.Mappings
{
    internal class BaseClassMap<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseClass
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().HasColumnName("Id");
            builder.Property(p => p.DataHoraCadastro).IsRequired().HasColumnName("DataHoraCadastro");
        }
    }
}
