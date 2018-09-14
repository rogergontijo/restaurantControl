using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Validations;
using RestaurantControl.Domain.Services;
using RestaurantControl.Domain.Validations;

namespace RestaurantControl.Test
{
    [TestClass]
    public class RestaurantTestServices
    {        
        [TestMethod]
        public void ShouldInsert()
        {
            var restaurant = new Restaurant()
            {
                Nome = "Restaurante do Fogaça"
            };

            var moq = new Mock<IRestaurantRepository>();
            moq.Setup(p => p.Insert(It.IsAny<Restaurant>()));
            var _service = new RestaurantService(moq.Object, new RestaurantValidation(moq.Object));

            var objReturn = _service.Insert(restaurant);

            Assert.IsNotNull(objReturn);
        }
    }
}
