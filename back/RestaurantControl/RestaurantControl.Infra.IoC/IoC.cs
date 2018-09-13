using Microsoft.Extensions.DependencyInjection;
using RestaurantControl.Application.Interfaces;
using RestaurantControl.Application.Services;
using RestaurantControl.Domain.Interfaces.Repositories;
using RestaurantControl.Domain.Interfaces.Services;
using RestaurantControl.Domain.Interfaces.Validations;
using RestaurantControl.Domain.Services;
using RestaurantControl.Domain.Validations;
using RestaurantControl.Infra.Data.Repositories;

namespace RestaurantControl.Infra.IoC
{
    public class IoC
    {
        IServiceCollection _service;
        public IoC(IServiceCollection service)
        {
            _service = service;
        }

        public void RegisterServices()
        {
            _service.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            _service.AddScoped<IRestaurantRepository, RestaurantRepository>();
            _service.AddScoped<IDishRepository, DishRepository>();
            _service.AddScoped(typeof(IBaseValidation<>), typeof(BaseValidation<>));
            _service.AddScoped<IRestaurantValidation, RestaurantValidation>();
            _service.AddScoped<IDishValidation, DishValidation>();
            _service.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            _service.AddScoped<IRestaurantService, RestaurantService>();
            _service.AddScoped<IDishService, DishService>();
            _service.AddScoped(typeof(IAppBaseService<,>), typeof(AppBaseService<,>));
            _service.AddScoped<IAppRestaurantService, AppRestaurantService>();
            _service.AddScoped<IAppDishService, AppDishService>();
        }

    }
}
