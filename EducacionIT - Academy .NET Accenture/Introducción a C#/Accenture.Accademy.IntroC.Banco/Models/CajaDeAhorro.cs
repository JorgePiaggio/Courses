using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Accademy.IntroC.Banco.Models
{
    public class CajaDeAhorro : Cuenta
    {

        public CajaDeAhorro(Cliente cliente, String cbu) : base(cliente, cbu)
        {
        }


        public override void Extraer(double monto)
        {
            // en caja de ahorro no se puede extraer mas q el saldo
            // costo de la extraccion = 0.01 % ;
            if( monto > this.Saldo)
            {
                throw new Exception("No puede extraer más que el saldo disponible");
            }

            double nuevoMonto = monto - (monto * 0.01);
            base.Extraer(nuevoMonto);
        }


        public override void Depositar(double monto)
        {
            // depositos > 10000 bonificacion 0.005 % 
            double nuevoMonto = monto;
            if(monto > 10000)
            {
                nuevoMonto += monto * 0.005;
            }
            base.Depositar(nuevoMonto);
        }

        public override string ToString()
        {
            return $"Cliente: {this.Cliente.Nombre} - DNI: {this.Cliente.Documento} - CajaDeAhorro: {this.Cbu} - Saldo: {this.Saldo} ";
        }
    }
}
