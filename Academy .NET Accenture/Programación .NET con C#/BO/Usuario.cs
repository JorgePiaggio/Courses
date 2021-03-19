using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Usuario
    {
        #region Constructores
        // constructor
        public Usuario() { }
        public Usuario(string nombre, string password, string email) 
        {
            Nombre = nombre;
            Password = password;
            Email =  email;
        }
        #endregion

        #region propiedades auto implementadas
        // propiedad auto implementada
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        #endregion


    }
}
