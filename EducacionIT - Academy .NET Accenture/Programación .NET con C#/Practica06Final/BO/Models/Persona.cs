using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public abstract class Persona
    {

        #region constructores
        public Persona() { }
        public Persona(int pId, string pNombre, string pApellido, string pDni, string pDomicilio, string pTelefono, string pEmail) {
            Id = pId;
            Nombre = pNombre; ;
            Apellido = pApellido;
            Dni = pDni;
            Domicilio = pDomicilio;
            Telefono = pTelefono;
            Email = pEmail;
        }
        #endregion

        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
    #endregion

}
