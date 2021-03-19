using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace LibSeguridad
{
    public class AdminSeguridad
    {
        /// <summary>
        /// Función para validar las credenciales del usuario
        /// </summary>
        /// <param name="nombre"> se espera el nombre del usuario de tipo cadena</param>
        /// <param name="password">se espera el password de tipo cadena. Debe tener 4 digitos</param>
        /// <returns>retorna true si el usuario existe en la base</returns>
        public bool autenticar(Usuario usuario)
        {
            if(usuario.Nombre == "juan" && usuario.Password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int registrar(Usuario usuario)
        {
            //TODO - completar implementación
            return 0;
        }
    }
}
