using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Accademy.IntroC.Banco.Models
{
    public class CuentaCorriente : Cuenta
    {
     
        public double SaldoDescubierto { get; }


        public CuentaCorriente(Cliente cliente, String cbu) : base(cliente, cbu)
        {
            this.SaldoDescubierto = -1000000;
        }


        public override void Extraer(double monto)
        {
            // puede quedar en negativo
            // montos mayores a 50000 se cobra 0.03 % la extraccion
            if (Saldo - monto < SaldoDescubierto)
            {
                throw new Exception("No hay suficiente saldo.");
            }
            else if (monto > 50000)
            {
                monto = monto - (monto * 0.03);
            }

            base.Extraer(monto);
        }


        public override void Depositar(double monto)
        {
            // por cada 100000 el banco te regala 1000
            double cantidad = Math.Floor( monto / 100000);
            double nuevoMonto = monto + (1000 * cantidad);

            base.Depositar(monto);
        }

        public override string ToString()
        {
            return $"Cliente: {this.Cliente.Nombre} - DNI: {this.Cliente.Documento} - CuentaCorriente: {this.Cbu} - Saldo: {this.Saldo} ";
        }

    }
}
