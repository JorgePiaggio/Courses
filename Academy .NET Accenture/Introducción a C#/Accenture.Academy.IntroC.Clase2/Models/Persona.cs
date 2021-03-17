using System;
using Accenture.Academy.IntroC.Clase2.Utils;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Academy.IntroC.Clase2.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad
        {
            get
            {
                /*
                 * int edad = DateTime.Today.Year - this.FechaDeNacimiento.Year;
                if( DateTime.Today.DayOfYear < this.FechaDeNacimiento.DayOfYear )
                {
                    edad--;
                }
                return edad;
                */
                return this.FechaDeNacimiento.GetAgeFromBirthDate();
            }
        
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} de edad {this.Edad}";
        }



    }
}
