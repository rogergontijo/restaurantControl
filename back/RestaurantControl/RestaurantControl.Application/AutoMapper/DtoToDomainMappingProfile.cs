using AutoMapper;
using RestaurantControl.Application.DTOs;
using RestaurantControl.Domain.Entities;

namespace RestaurantControl.Application.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public override string ProfileName => "DtoToDomainMap";

        public DtoToDomainMappingProfile()
        {
            CreateMap<DishDTO, Dish>();
            CreateMap<RestaurantDTO, Restaurant> ();
        }
    }
}
