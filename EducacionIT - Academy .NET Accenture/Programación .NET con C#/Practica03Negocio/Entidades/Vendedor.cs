using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        public Vendedor(string pNombre, string pApellido, DatosContacto datos) : base(pNombre, pApellido, datos) { }

    }
}
