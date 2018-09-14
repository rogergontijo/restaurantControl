using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Services;
using RestaurantControl.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Test
{
    [TestClass]
    public class DishTestServices
    {
        [TestMethod]
        public void ShouldInsert()
        {
            var dish = new Dish()
            {
                Nome = "Prato do Restaurante do Fogaça",
                Valor = 120,
                RestaurantId = 1
            };

            var moq = new Mock<IDishRepository>();
            moq.Setup(p => p.Insert(It.IsAny<Dish>()));
            var _service = new DishService(moq.Object, new DishValidation(moq.Object));

            var objReturn = _service.Insert(dish);

            Assert.IsNotNull(objReturn);
        }

        [TestMethod]
        public void ShouldNotInsertWithoutRestaurant()
        {
            var dish = new Dish()
            {
                Nome = "Prato Jackin",
                Valor = 200.00
            };

            var mock = new Mock<IDishRepository>();
            mock.Setup(p => p.Insert(It.IsAny<Dish>()));

            var _service = new DishService(mock.Object, new DishValidation(mock.Object));            

            Assert.ThrowsException<ArgumentNullException>(() => _service.Insert(dish));
        }
    }
}
