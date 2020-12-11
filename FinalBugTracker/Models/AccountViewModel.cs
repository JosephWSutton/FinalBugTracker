using System;
using System.ComponentModel.DataAnnotations;

namespace FinalBugTracker.Models
{
    public class RegisterViewModel
    {
        [MaxLength(40, ErrorMessage = "First Name cannot be greater than 40 characters")]
        [MinLength(1, ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(40, ErrorMessage = "Last Name cannot be greater than 40 characters")]
        [MinLength(1, ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(25, ErrorMessage = "Display Name cannot be greater than 25 characters")]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    
}
