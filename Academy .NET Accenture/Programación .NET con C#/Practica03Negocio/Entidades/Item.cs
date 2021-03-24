using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Item
    {
        public Item(int pCantidad, string pDesc, decimal pPrecioUnitario, decimal pImporte)
        {
            Cantidad = pCantidad;
            Descripcion = pDesc;
            PrecioUnitario = pPrecioUnitario;
            Importe = pImporte;
        }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; }
    }
}
