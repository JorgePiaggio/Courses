using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatosProducto.Models
{
    public class Producto
    {
        #region constructores
        public Producto() { }
        public Producto(string pNombre, string pColor, decimal pPrecio)
        {
            Nombre = pNombre;
            Color = pColor;
            Precio = pPrecio;
        }
        public Producto(int pId, string pNombre, string pColor, decimal pPrecio)
        {
            Id = pId;
            Nombre = pNombre;
            Color = pColor;
            Precio = pPrecio;
        }
        #endregion

        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        #endregion
    }
}
