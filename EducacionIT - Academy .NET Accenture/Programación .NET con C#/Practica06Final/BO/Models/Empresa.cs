using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Empresa
    {

        #region constructores
        public Empresa() { }
        public Empresa (int pId, string pNombe, string pCuit, string pDomicilio, string pTelefono, string pEmail)
        {
            Id = pId;
            Nombre = pNombe;
            Cuit = pCuit;
            Domicilio = pDomicilio;
            Telefono = pTelefono;
            Email = pEmail;
        }
        #endregion

        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        #endregion

    }
}
