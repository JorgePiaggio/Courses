using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTransportes.Models
{
    public class Chofer
    {
        public Chofer() { }


        [Required(ErrorMessage = "Campo requerido")]
        public int ChoferID { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string DNI { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [EmailAddress(ErrorMessage ="Email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int NroRegistro { get; set; }



    }
}