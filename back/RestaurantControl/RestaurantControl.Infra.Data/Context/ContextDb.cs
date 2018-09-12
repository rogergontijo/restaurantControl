using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RestaurantControl.Domain.Entities;
using RestaurantControl.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Infra.Data.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        private bool _rollBack;
        public IDbContextTransaction Transaction { get; private set; }

        public ContextDb(DbContextOptions<ContextDb> options)
            : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RestaurantMap());
            modelBuilder.ApplyConfiguration(new DishMap());            
        }

        public IDbContextTransaction BeginTransaction() => Transaction ?? (Transaction = this.Database.BeginTransaction());

        /// <summary>
        /// Método responsável por desfazer uma transaction
        /// </summary>
        private void RollBack()
        {
            if (Transaction != null && !_rollBack)
            {
                Transaction.Rollback();
                _rollBack = true;
            }
        }

        /// <summary>
        /// Método responsável por persistir os dados no banco
        /// </summary>
        public override int SaveChanges()
        {
            try
            {                
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método responsável por realizar o commit da transaction
        /// </summary>
        private void Commit()
        {
            if (Transaction != null && !_rollBack)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }
    }
}
