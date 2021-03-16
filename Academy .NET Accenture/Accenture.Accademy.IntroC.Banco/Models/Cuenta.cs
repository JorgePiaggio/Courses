using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Accademy.IntroC.Banco.Models
{
    public abstract class Cuenta
    {
        public string Cbu { get; }
        public double Saldo { get; private set; }
        public Cliente Cliente { get; }
        public DateTime FechaApertura { get; }


        public Cuenta(Cliente cliente, String cbu)
        {
            this.Cliente = cliente;
            this.Cbu = cbu;
            this.FechaApertura = DateTime.Today;
            //this.Saldo = 0; // redundante => las variables se inicializan en 0 en C#
        }


        public virtual void Depositar(double monto)
        {
            this.Saldo += monto;
        }


        public virtual void Extraer(double monto)
        {
            this.Saldo -= monto;
        }

    }
}
