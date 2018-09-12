using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Domain.Validations
{
    public class DishValidation : BaseValidation<Dish>, IDishValidation
    {
        private readonly IDishRepository _repository;

        public DishValidation(IDishRepository repository)
            : base (repository)
        {
            _repository = repository;
        }

        protected override bool Validate(Dish entity)
        {
            if (base.Validate(entity))
            {
                if (string.IsNullOrWhiteSpace(entity.Nome))
                {
                    throw new ArgumentNullException("Dados obrigatórios não informados.");
                }
            }

            return true;
        }
    }
}
