namespace Models.Security
{
    public class RespuestaAutenticacionModel
    {
        #region Propiedades

        /// <summary>
        /// Indica el resultado de la validación del usuario
        /// </summary>
        public bool Autenticado { get; set; }

        /// <summary>
        /// Mensaje del resultado del proceso de autenticación
        /// </summary>
        public string Mensaje { get; set; }


        /// <summary>
        /// Token de seguridad JWT
        /// </summary>
        public string JWTToken { get; set; }


        #endregion
    }
}
