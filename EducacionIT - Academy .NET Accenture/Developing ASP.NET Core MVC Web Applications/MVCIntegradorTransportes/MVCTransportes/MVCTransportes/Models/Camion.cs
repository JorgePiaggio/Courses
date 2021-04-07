using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTransportes.Models
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo, string matricula, string caracteristicas, Chofer chofer) : base(marca, modelo, matricula, caracteristicas, chofer) { }

        [Required(ErrorMessage = "Campo requerido")]
        public int CamionID { get; set; }
    }
}