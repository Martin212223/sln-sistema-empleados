using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class AfterYear2000Attribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            DateTime fecha = Convert.ToDateTime(value);

            if (fecha < new DateTime())

        }

    }
}
