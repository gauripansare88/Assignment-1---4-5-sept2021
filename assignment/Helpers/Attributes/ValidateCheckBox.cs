using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Helpers.Attributes
{
    public class ValidateCheckBox: ValidationAttribute
    {
        //public void AddValidation(ClientModelValidationContext context)
        //{
        //    context.Attributes.Add("data-val-checkbox", ErrorMessage);
        //}

        public override bool IsValid(object value)
        {
            return (bool)value;
           
        }
    }
}
