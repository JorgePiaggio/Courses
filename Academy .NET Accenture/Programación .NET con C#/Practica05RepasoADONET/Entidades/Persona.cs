using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public Persona() { }
        public Persona(int pId, string pNombre, string pApellido, DateTime pFechaDeNacimiento) 
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            FechaDeNacimiento = pFechaDeNacimiento;
        }

        public int Id { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }
}
