using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSWMedicos.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Especialidad { get; set; }
        [Required]
        public string NroMatricula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
    }
}
