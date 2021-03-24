using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, DatosContacto datos) : base(pNombre, pApellido, datos)
        {
            this.CUIT = pCUIT;
        }

        public string CUIT { get; set; }

    }
}
