using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosContacto
    {
        public DatosContacto(string pEmail, string pDireccion, string pTelefono)
        {
            Email = pEmail;
            Direccion = pDireccion;
            Telefono = pTelefono;
        }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
