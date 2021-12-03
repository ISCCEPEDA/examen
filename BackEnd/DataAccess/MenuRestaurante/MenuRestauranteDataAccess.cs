using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Models.MenuRestaurante;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace DataAccess.MenuRestaurante
{
    public class MenuRestauranteDataAccess : IDataAccess
    {
        #region Campos

        private readonly IConfiguration _config;
        #endregion

        #region Constructores
        public MenuRestauranteDataAccess(IConfiguration config)
        {
            _config = config;
        }

        #endregion

        public List<DescripcionPlatillo> Obtener()
        {
            using(var conn = new SqlConnection(_config.GetConnectionString("DBConnectionDefault")))
            {
                return conn.Query<DescripcionPlatillo>("uspObtenerPlatillos",
                       commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void Insertar(DescripcionPlatillo model)
        {
            using (var conn = new SqlConnection(_config.GetConnectionString("DBConnectionDefault")))
            {
                conn.Execute("uspInsertarPlatillo",
                    new { Id = Guid.NewGuid(), 
                        IdCategoria = model.IdCategoria,
                        NombrePlatillo = model.NombrePlatillo,
                        Ingredientes = model.Ingredientes,
                        Peso = model.Peso,
                        Calorias = model.Calorias,
                        Precio = model.Precio
                    }, 
                    commandType: CommandType.StoredProcedure);
            }
        }

        public DescripcionPlatillo ObtenerPorId(Guid Id)
        {
            using (var conn = new SqlConnection(_config.GetConnectionString("DBConnectionDefault")))
            {
                return conn.Query<DescripcionPlatillo>("uspObtenerPlatilloPorId",
                    new { Id = Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void Actualizar(DescripcionPlatillo model)
        {
            using (var conn = new SqlConnection(_config.GetConnectionString("DBConnectionDefault")))
            {
                conn.Execute("uspActualizarPlatillo",
                    new
                    {
                        Id = model.Id,
                        IdCategoria = model.IdCategoria,
                        NombrePlatillo = model.NombrePlatillo,
                        Ingredientes = model.Ingredientes,
                        Peso = model.Peso,
                        Calorias = model.Calorias,
                        Precio = model.Precio
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void Eliminar(Guid Id)
        {
            using (var conn = new SqlConnection(_config.GetConnectionString("DBConnectionDefault")))
            {
                conn.Execute("uspEliminarPlatillo",
                    new { Id = Id }, commandType: CommandType.StoredProcedure);
            }
        }

        public List<DescripcionPlatillo> ObtenerPlatillosPorCategoria(Guid Id)
        {
            using (var conn = new SqlConnection(_config.GetConnectionString("DBConnectionDefault")))
            {
                return conn.Query<DescripcionPlatillo>("uspObtenerPlatilloPorCategoria",
                    new { Id = Id }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
