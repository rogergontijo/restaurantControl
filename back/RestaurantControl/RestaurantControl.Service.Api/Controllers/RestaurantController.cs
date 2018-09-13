using Microsoft.AspNetCore.Mvc;
using RestaurantControl.Application.DTOs;
using RestaurantControl.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestaurantControl.Service.Api.Controllers
{
    [Route("api/restaurants")]    
    public class RestaurantController : Controller
    {
        private readonly IAppRestaurantService _appService;

        public RestaurantController(IAppRestaurantService appService)
        {
            _appService = appService;
        }

        /// <summary>
        /// Método responsável por retornar todos os restaurantes;
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<RestaurantDTO> GetAll()
        {
            try
            {
                return _appService.GetAll();
            }
            catch
            {
                return new List<RestaurantDTO>();
            }
        }

        /// <summary>
        /// Método responsável por retornar um restaurante pelo seu id.
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
        /// Método responsável por inserir um novo restaurante.
        /// </summary>
        /// <param name="restaurantDTO"></param>
        [HttpPost]
        public IActionResult Post([FromBody] RestaurantDTO restaurantDTO)
        {
            try
            {
                _appService.Insert(restaurantDTO);
                return new OkResult();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método responsável por alterar um restaurante existente.
        /// </summary>        
        /// <param name="restaurantDTO"></param>
        [HttpPut]
        public IActionResult Put([FromBody] RestaurantDTO restaurantDTO)
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
        /// Método responsável por excluir um restaurante pelo seu id.
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