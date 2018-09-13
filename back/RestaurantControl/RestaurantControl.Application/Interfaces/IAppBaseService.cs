﻿using RestaurantControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantControl.Application.Interfaces
{
    public interface IAppBaseService<TEntityDomain, TEntityDTO>
        where TEntityDomain : BaseClass
        where TEntityDTO : class
    {
        void Insert(TEntityDTO entityDTO);
        void Update(TEntityDTO entityDTO);
        void Delete(int id);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();
        TEntityDTO GetByName(string name);
        void Dispose();
    }
}
