using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTransportes.Models
{
    public class CheckModelYear : ValidationAttribute
    {
        public CheckModelYear()
        {
            ErrorMessage = "El Modelo Ingresado Debe Ser Posterior a 2015";
        }
        public override bool IsValid(object value)
        {
            int year = Convert.ToInt32(value);
            if (year > 2015)
                return true;
            return false;
        }
    }
}