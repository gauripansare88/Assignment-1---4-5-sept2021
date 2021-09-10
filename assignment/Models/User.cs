using assignment.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Models
{
    public class Countries
    {
        public String Name;
        public String [] Cities;
    }
    public class User
    {

        [Required(ErrorMessage = "Please Enter Name")]
        [MinLength(3,ErrorMessage = "Name should be atleast 3 charaters")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please Enter Correct Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Please Enter Correct Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }

       
        public string Country { get; set; }
        public string City { get; set; }

        public string gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Terms
        {
            get; set;

        }
    }
}
