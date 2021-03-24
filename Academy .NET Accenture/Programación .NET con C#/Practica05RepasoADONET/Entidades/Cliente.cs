using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public Cliente(int pId, string pNombre, string pApellido, DateTime pFechaDeNacimiento) : base(pId, pNombre, pApellido, pFechaDeNacimiento) { }


    }
}
