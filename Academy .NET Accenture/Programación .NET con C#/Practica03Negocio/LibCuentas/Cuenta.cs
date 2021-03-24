using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCuentas
{
    public abstract class Cuenta
    {
        public int idCuenta { get; set; }
        public Cuenta(int pidCuenta)
        {
            idCuenta = pidCuenta;
        }

        public virtual void CalcularInteres()
        {
            //TODO completar metodo
        }
    }
}
