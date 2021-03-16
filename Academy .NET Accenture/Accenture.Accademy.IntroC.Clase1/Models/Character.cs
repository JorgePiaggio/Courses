using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Accademy.IntroC.Clase1.Models
{
    public class Character
    {
        /* FORMA TRADICIONAL
        
        private string _nombre;

        public string getNombre()
        {
            return _nombre;
        }
        public void setNombre(string value)
        {
            this._nombre = value;
        }

        */

        /* CONCEPTO DE PROPIEDAD     
        
        private string _nombre;
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        */

        // SUGAR SYNTAX

        public string Nombre { get; set; }
        public string Alias { get; set; }
        public int Edad { get; set; }

        public List<String> Poderes { get; } // no permite asignar otra lista, pero si agregar elementos

        public Character()      // aunque no tenga set, en el constructor está permitido
        {
            this.Poderes = new List<String>();
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{this.Nombre} alias {this.Alias} de edad {this.Edad}";
        }
    }
}
