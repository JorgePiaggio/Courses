using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public Factura(string pTipo, string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIVA, string pCondicionVenta, string pDetalle, decimal pTotal, DateTime pFechaEntrega) : base(pNumero, pFecha, pCliente, pDireccion, pCondicionIVA, pCondicionVenta, pDetalle, pTotal)
        {
            Tipo = pTipo;
        }
        public string Tipo { get; set; }
    }
}
