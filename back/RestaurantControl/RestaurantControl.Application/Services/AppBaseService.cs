using AutoMapper;
using RestaurantControl.Application.Interfaces;
using RestaurantControl.Domain.Entities;
using RestaurantControl.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RestaurantControl.Application.Services
{
    public class AppBaseService<TEntityDomain, TEntityDTO> : IDisposable, IAppBaseService<TEntityDomain, TEntityDTO>
        where TEntityDomain : BaseClass
        where TEntityDTO : class
    {
        private readonly IBaseService<TEntityDomain> _service;

        public AppBaseService(IBaseService<TEntityDomain> service)
        {
            _service = service;
        }

        public IEnumerable<TEntityDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<TEntityDomain>, IEnumerable<TEntityDTO>>(_service.GetAll());
        }

        public TEntityDTO GetById(int id)
        {
            return Mapper.Map<TEntityDomain, TEntityDTO>(_service.GetById(id));
        }

        public TEntityDTO GetByName(string name)
        {
            return Mapper.Map<TEntityDomain, TEntityDTO>(_service.GetByName(name));
        }

        public void Insert(TEntityDTO entityDTO)
        {
            _service.Insert(Mapper.Map<TEntityDTO, TEntityDomain>(entityDTO));
        }

        public void Update(TEntityDTO entityDTO)
        {
            _service.Update(Mapper.Map<TEntityDTO, TEntityDomain>(entityDTO));
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
