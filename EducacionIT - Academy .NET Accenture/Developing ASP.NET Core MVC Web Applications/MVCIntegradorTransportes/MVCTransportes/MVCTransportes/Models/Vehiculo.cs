using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTransportes.Models
{
    public abstract class Vehiculo
    {
        public Vehiculo() { }

        public Vehiculo(string marca, string modelo, string matricula, string caract, Chofer chofer) {
            this.Chofer = chofer;
            this.Marca = marca;
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Caracteristicas = caract;
        }



        [Required(ErrorMessage = "Campo requerido")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [CheckModelYear]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Caracteristicas { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public Chofer Chofer { get; set; }



    }
}