using Business.MenuRestaurante;
using DataAccess.MenuRestaurante;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models;
using Models.MenuRestaurante;
using System;

namespace APIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly ILogger<RestauranteController> _logger;
        private readonly MenuRestauranteBusiness business;
        public RestauranteController
        (
            IConfiguration configuration,
            ILogger<RestauranteController> logger
        )
        {
            var dataAccess = new MenuRestauranteDataAccess(configuration);
            business = new MenuRestauranteBusiness(dataAccess);
            _logger = logger;
        }

        /// <summary>
        /// EndPoint para obtener todos los platillos
        /// </summary>
        /// <returns>Respuesta con listado de platillos</returns>
        [HttpGet]
        public ActionResult<ResponseListModel> Get()
        {
            var respuesta = new ResponseListModel();
            try
            {
                respuesta = business.ObtenerPlatillos();

                if (respuesta.Status)
                {
                    return Ok(respuesta);
                }
                else
                {
                    return NotFound(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.Message = "Ocurrió una excepción al obtener los platillos.";
                _logger.LogError(ex.Message);

                return BadRequest(respuesta);
            }
        }


        /// <summary>
        /// Obtiene platillo por Id
        /// </summary>
        /// <param name="id">Id del platillo</param>
        /// <returns>Platillo</returns>
        [HttpGet("{id}")]
        public ActionResult<DescripcionPlatillo> Get(Guid id)
        {
            try
            {
                var respuesta = business.ObtenerPorId(id);

                if (respuesta != null )
                {
                    return Ok(respuesta);
                }
                else
                {
                    return NotFound(new ResponseServiceModel
                    {
                        Status = false,
                        Message = "No se encontró el elemento."
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new ResponseServiceModel
                {
                    Status = false,
                    Message = "Ocurrio una excepción al obtener el elemento."
                });
            }
        }


        /// <summary>
        /// Inserta un platillo
        /// </summary>
        /// <param name="model">Entidad con el platillo</param>
        /// <returns>Respuesta del servicio</returns>
        [HttpPost]
        public ActionResult<ResponseServiceModel> Post([FromBody] DescripcionPlatillo model)
        {
            var respuesta = new ResponseServiceModel();
            try
            {
                respuesta = business.InsertarPlatillo(model);

                if (respuesta.Status)
                {
                    return Ok(respuesta);
                }
                else
                {
                    return BadRequest(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.Message = "Ocurrió una excepción al insertar.";
                _logger.LogError(ex.Message);

                return BadRequest(respuesta);
            }
        }


        /// <summary>
        /// Actualiza un platillo
        /// </summary>
        /// <param name="id">Id del platillo</param>
        /// <param name="model">Entidad con los datos del platillo</param>
        /// <returns>Respuesta del servicio</returns>
        [HttpPut("{id}")]
        public ActionResult<ResponseServiceModel> Put(Guid id, [FromBody] DescripcionPlatillo model)
        {
            var respuesta = new ResponseServiceModel();
            try
            {
                model.Id = id;
                respuesta = business.ActualizarPlatillo(model);

                if (respuesta.Status)
                {
                    return Ok(respuesta);
                }
                else
                {
                    return BadRequest(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.Message = "Ocurrió una excepción al actualizar.";
                _logger.LogError(ex.Message);

                return BadRequest(respuesta);
            }
        }


        /// <summary>
        /// Elimina un platillo
        /// </summary>
        /// <param name="id">Id del platillo</param>
        /// <returns>Respuesta del borrado</returns>
        [HttpDelete("{id}")]
        public ActionResult<ResponseServiceModel> Delete(Guid id)
        {
            var respuesta = new ResponseServiceModel();
            try
            {
                respuesta = business.EliminarPlatillo(id);

                if (respuesta.Status)
                {
                    return Ok(respuesta);
                }
                else
                {
                    return BadRequest(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.Message = "Ocurrió una excepción al eliminar.";
                _logger.LogError(ex.Message);

                return BadRequest(respuesta);
            }
        }


        /// <summary>
        /// Obtiene los platillos por id de categoría
        /// </summary>
        /// <param name="id">Id de la categoría</param>
        /// <returns>Listado de platillos</returns>
        [HttpGet("PlatillosPorCategoria/{id}")]
        public ActionResult<DescripcionPlatillo> GetPorCategoria(Guid id)
        {
            var respuesta = new ResponseListModel();
            try
            {
                respuesta = business.ObtenerPlatillosPorCategoria(id);

                if (respuesta.Status)
                {
                    return Ok(respuesta);
                }
                else
                {
                    return NotFound(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.Message = "Ocurrió una excepción al obtener los platillos.";
                _logger.LogError(ex.Message);

                return BadRequest(respuesta);
            }
        }
    }
}
