using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTransportes.Models
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo, string matricula, string caracteristicas, Chofer chofer) : base(marca, modelo, matricula, caracteristicas, chofer) { }

        [Required(ErrorMessage = "Campo requerido")]
        public int AutoID { get; set; }
    }
}