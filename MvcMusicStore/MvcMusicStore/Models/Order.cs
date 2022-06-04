using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual DateTime OrderDate { get; set; }

        [Required] 
        [StringLength(160, MinimumLength = 3)]
        // both client side and server side
        //range [Range(33,44)] for age or number
        //compare [Compare("Email")] // first attribute name is Email and compare is on top of Re-enter email
        //remote // for database check, eg: username, emaill //[Remote("CheckUserName","Account")]
        [Display(Name = "UserName")]
        public virtual string Username { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 3,ErrorMessage="{0} must be greater than 3 and less than 160 char..")]
        [Display(Name = "First Name",Order =15001)]
        public virtual string FirstName { get; set; }

        [Required(ErrorMessageResourceType = typeof(ErrorMessages_NP), ErrorMessageResourceName = "LastNameRequired")]
        [StringLength(160, MinimumLength = 3,ErrorMessageResourceType = typeof(ErrorMessages_NP),ErrorMessageResourceName ="LastNameLong")]
        [Display(Name = "Last Name", Order = 15002)]
        public virtual string LastName { get; set; }

        [Required]
        public virtual string Address { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string State { get; set; }

        [Required]
        public virtual string PostalCode { get; set; }

        [Required]
        public virtual string Country { get; set; }

        [Required]
        public virtual string Phone { get; set; }

        [Required(ErrorMessage ="Your {0} is required..")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="Enter valid Email Address..")]
        public virtual string Email { get; set; }

        public virtual decimal Total { get; set; }

    }
}