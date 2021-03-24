using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class DocumentoComercial
    {
        public DocumentoComercial(string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, List<Item> pDetalle, decimal pTotal)
        {
            Numero = pNumero;
            Fecha = pFecha;
            Cliente = pCliente;
            Direccion = pDireccion;
            CondicionIVA = pCondicionIVA;
            CondicionVenta = pCondicionVenta;
            Detalle = pDetalle;
            Total = pTotal;
        }


        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List<Item> Detalle { get; set; }
        public decimal Total { get; set; }

    }
}
