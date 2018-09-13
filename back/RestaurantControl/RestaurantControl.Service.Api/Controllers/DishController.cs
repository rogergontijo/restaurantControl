using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantControl.Application.DTOs;
using RestaurantControl.Application.Interfaces;

namespace RestaurantControl.Service.Api.Controllers
{    
    [Route("api/dishes")]    
    public class DishController : Controller
    {
        private readonly IAppDishService _appService;

        public DishController(IAppDishService appService)
        {
            _appService = appService;
        }

        /// <summary>
        /// Método responsável por retornar todos os pratos;
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<DishDTO> GetAll()
        {
            try
            {
                return _appService.GetAll();
            }
            catch 
            {
                return new List<DishDTO>();
            }
        }

        /// <summary>
        /// Método responsável por retornar um prato pelo seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return new OkObjectResult(_appService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método responsável por inserir um novo prato.
        /// </summary>
        /// <param name="dishDTO"></param>
        [HttpPost]
        public IActionResult Post([FromBody] DishDTO dishDTO)
        {
            try
            {
                _appService.Insert(dishDTO);
                return new OkResult();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método responsável por alterar um prato existente.
        /// </summary>        
        /// <param name="dishDTO"></param>
        [HttpPut]
        public IActionResult Put([FromBody] DishDTO dishDTO)
        {
            try
            {
                _appService.Update(dishDTO);
                return new OkResult();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método responsável por excluir um prato pelo seu id.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _appService.Delete(id);
                return new OkResult();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}