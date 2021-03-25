using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Cliente : Persona
    {
        #region constructores
        public Cliente(int pId, string pNombre, string pApellido, string pDni, string pDomicilio, string pTelefono, string pEmail) : base(pId, pNombre, pApellido, pDni, pDomicilio, pTelefono, pEmail) { }

        #endregion
    }
}
