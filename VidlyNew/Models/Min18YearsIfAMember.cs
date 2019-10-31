using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace VidlyNew.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MemberShipType.Unknown || 
               customer.MembershipTypeId == MemberShipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if(customer.Birthdata == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            var age = DateTime.Today.Year - customer.Birthdata.Value.Year;

            return (age > 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Should be at least 18 year old");
        }
    }
}