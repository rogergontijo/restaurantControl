using AutoMapper;

namespace RestaurantControl.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToDtoMappingProfile>();
                cfg.AddProfile<DtoToDomainMappingProfile>();
            });
        }
    }
}
