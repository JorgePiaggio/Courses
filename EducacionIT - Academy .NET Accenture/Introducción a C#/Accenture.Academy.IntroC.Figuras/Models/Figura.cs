using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Academy.IntroC.Figuras.Models
{
    public abstract class Figura
    {
        public double BaseFig { get; set; }
        public double AlturaFig { get; set; }

        public virtual double CalcularArea()
        {
            return BaseFig * AlturaFig;
        }
    }
}
