using Models.MenuRestaurante;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccess
    {
        public List<DescripcionPlatillo> Obtener();

        public void Insertar(DescripcionPlatillo model);
        public DescripcionPlatillo ObtenerPorId(Guid Id);
        public void Actualizar(DescripcionPlatillo model);
        public void Eliminar(Guid Id);
        public List<DescripcionPlatillo> ObtenerPlatillosPorCategoria(Guid Id);
    }
}