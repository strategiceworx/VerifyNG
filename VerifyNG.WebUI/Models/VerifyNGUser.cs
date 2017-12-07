using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VerifyNG.WebUI.Models
{
    public class VerifyNGUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber )]
        public byte TelephoneNumber { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Compare("TelephoneNumber", ErrorMessage = "The Telephone Number and confirmation Telephone Number do not match.")]
        public byte ConfirmTelephoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateofBirth { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Confirm Date of Birth")]
        [Compare("DateOfBirth", ErrorMessage = "The date of birth and confirmation date of birth do not match.")]
        public DateTime ConfirmDateofBirth { get; set; }
        
        
    }
}