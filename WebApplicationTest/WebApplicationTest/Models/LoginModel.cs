using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationTest.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "The UserName is required")]
        [Display(Name ="User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="The Password is Required")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="The password is invalid")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }


        [Display(Name ="Remember Me?")]
        public bool RememberMe { get; set; }
    }
}