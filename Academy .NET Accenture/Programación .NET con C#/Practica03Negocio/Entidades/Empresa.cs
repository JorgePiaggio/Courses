using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        #region constructores
        public Empresa() { }
        public Empresa(string pNombre, string pCUIT, Persona pContacto)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
        }
        public Empresa(string pNombre, string pCUIT, Persona pContacto, DatosContacto datosCont)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.DatosContacto = datosCont;
        }
        public Empresa(string pNombre, string pCUIT, DatosContacto datosCont)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.DatosContacto = datosCont;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }
        public DatosContacto DatosContacto { get; set; }
        #endregion
    
    
    }

    }
