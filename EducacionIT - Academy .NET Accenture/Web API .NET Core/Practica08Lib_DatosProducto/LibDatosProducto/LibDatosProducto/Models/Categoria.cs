using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatosProducto.Models
{
    public class Categoria
    {

        #region constructores

        public Categoria() { }
        public Categoria(int pId, string pNombre, string pDescripcion) {
            Id = pId;
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }
        public Categoria(string pNombre, string pDescripcion)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }
        #endregion

        #region propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        #endregion

    }
}
