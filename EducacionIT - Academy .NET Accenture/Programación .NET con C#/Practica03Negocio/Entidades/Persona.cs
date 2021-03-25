using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region constructor
        public Persona(string pNombre, string pApellido)
        {
            Nombre = pNombre;
            Apellido = pApellido;
        }
        public Persona(string pNombre, string pApellido, DatosContacto datos)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            DatosContacto = datos;
        }
        #endregion


        #region propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }

        #endregion

   
    }
}
