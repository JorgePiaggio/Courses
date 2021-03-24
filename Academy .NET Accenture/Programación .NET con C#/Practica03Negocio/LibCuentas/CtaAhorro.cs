using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCuentas
{
    public class CtaAhorro : Cuenta
    {
        public CtaAhorro(int pIdCuenta) : base(pIdCuenta) { }


        public override void CalcularInteres()
        {
            base.CalcularInteres();
        }
    }
}
