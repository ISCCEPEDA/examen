using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MenuRestaurante
{
    public class DescripcionPlatillo
    {
        public Guid Id { get; set; }
        public Guid IdCategoria { get; set; }

        public string NombrePlatillo { get; set; }

        public string Ingredientes { get; set; }

        public decimal Peso { get; set; }
        public decimal Calorias { get; set; }

        [Range(0.0, 1000, ErrorMessage = "El {0} debe ser menor a {2}.")]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }
    }
}
