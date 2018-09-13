using AutoMapper;
using RestaurantControl.Application.DTOs;
using RestaurantControl.Domain.Entities;

namespace RestaurantControl.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public override string ProfileName => "DomainToDtoMap";        

        public DomainToDtoMappingProfile()
        {
            CreateMap<Dish, DishDTO>();
            CreateMap<Restaurant, RestaurantDTO>();
        }
    }
}
