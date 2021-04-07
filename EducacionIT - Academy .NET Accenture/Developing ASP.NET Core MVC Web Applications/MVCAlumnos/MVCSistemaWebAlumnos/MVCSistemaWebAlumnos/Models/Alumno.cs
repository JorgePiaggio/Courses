using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSistemaWebAlumnos.Models
{
    public class Alumno
    {
        [Required(ErrorMessage = "Campo obligatorio")] 
        public int AlumnoID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")] 
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")] 
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")] 
        public string DNI { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}