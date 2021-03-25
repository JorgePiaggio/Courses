using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Academy.IntroC.Clase2.Models
{
    class Alumno
    {
        public string NombreCompleto { get; set; }

        public int Edad { get; set; }




        public override string ToString()
        {
            return $"Nombre: {this.NombreCompleto} - Edad: {this.Edad}";
        }
    }
}
