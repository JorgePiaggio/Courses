using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebClinica.Models
{
    public class Medico
    {

        #region propiedades

        [Required(ErrorMessage = "Campo obligatorio")]
        public int MedicoID { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(30)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50)]
        public string Ciudad { get; set; }

        #endregion


    }
}