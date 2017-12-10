using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VerifyNG.WebUI.Models
{
   
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Telephone Number")]
        [Phone]
        public string TelephoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Phone]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 11)]
        [Display(Name = "Phone Number")]
        public string TelephoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Password { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Confirm Date of Birth")]
        [Compare("Password", ErrorMessage = "The date of birth and confirmation date of birth do not match.")]
        public DateTime ConfirmPassword { get; set; }

    }
}
