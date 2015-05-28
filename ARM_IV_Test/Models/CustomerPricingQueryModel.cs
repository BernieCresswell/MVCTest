using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARM_IV_Test.Models
{
    public class CustomerPricingQueryModel
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Address1")]
        public string Address1 { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }

        
        [Required]
        [Display(Name = "Products")]
        public IEnumerable<SelectListItem> Products { get; set; }  //value is product ID in database


        public string[] SelectedProducts { get; set; }  // these are what teh user selected
        
    }
}