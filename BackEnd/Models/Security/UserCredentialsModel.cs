using System.ComponentModel.DataAnnotations;

namespace Models.Security
{
    public class UserCredentialsModel
    {
        #region Propiedades

        /// <summary>
        /// Usuario
        /// </summary>
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string usuario { get; set; }

        /// <summary>
        /// Contraseña
        /// </summary>
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string password { get; set; }

        #endregion
    }
}
