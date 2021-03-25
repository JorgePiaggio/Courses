using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Vendedor : Persona
    {
        #region constructores
        public Vendedor(int pId, string pNombre, string pApellido, string pDni, string pDomicilio, string pTelefono, string pEmail, decimal pComision) : base(pId, pNombre, pApellido, pDni, pDomicilio, pTelefono, pEmail) {
            Comision = pComision;
        }

        #endregion

        #region propiedades

        public decimal Comision { get; set; }
        #endregion


    }
}
