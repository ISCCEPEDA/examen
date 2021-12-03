using DataAccess;
using DataAccess.MenuRestaurante;
using Microsoft.Extensions.Configuration;
using Models;
using Models.MenuRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MenuRestaurante
{
    public class MenuRestauranteBusiness
    {
        private IDataAccess _dataAccess; 
        public MenuRestauranteBusiness(IDataAccess dataAcess)
        {
            _dataAccess = dataAcess;
        }

        public ResponseListModel ObtenerPlatillos()
        {
            
            //Instancia para la respuesta del servicio
            var response = new ResponseListModel();

            response.listado = _dataAccess.Obtener();
            if (response.listado.Count() > 0)
            {
                response.Status = true;
            }
            else
            {
                response.Message = $"No se encontraron platillos.";
            }

            return response;
        }

        public ResponseServiceModel InsertarPlatillo(DescripcionPlatillo model)
        {
            //Instancia para la respuesta del servicio
            var response = new ResponseServiceModel();

            _dataAccess.Insertar(model);
            response.Status = true;

            return response;
        }

        public DescripcionPlatillo ObtenerPorId(Guid Id)
        {
            return _dataAccess.ObtenerPorId(Id);
        }

        public ResponseServiceModel ActualizarPlatillo(DescripcionPlatillo model)
        {
            //Instancia para la respuesta del servicio
            var response = new ResponseServiceModel();

            _dataAccess.Actualizar(model);
            response.Status = true;

            return response;
        }

        public ResponseServiceModel EliminarPlatillo(Guid Id)
        {
            //Instancia para la respuesta del servicio
            var response = new ResponseServiceModel();

            _dataAccess.Eliminar(Id);
            response.Status = true;

            return response;
        }

        public ResponseListModel ObtenerPlatillosPorCategoria(Guid id)
        {
            //Instancia para la respuesta del servicio
            var response = new ResponseListModel();

            response.listado = _dataAccess.ObtenerPlatillosPorCategoria(id);
            if (response.listado.Count() > 0)
            {
                response.Status = true;
            }
            else
            {
                response.Message = $"No se encontraron platillos.";
            }

            return response;
        }
    }
}
