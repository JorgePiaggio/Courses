using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Academy.IntroC.Figuras.Models
{
    public class Triangulo : Figura
    {

        public override double CalcularArea()
        {
            return ( base.CalcularArea() / 2 );
        }


    }
}
