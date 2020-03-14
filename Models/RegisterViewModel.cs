using System.ComponentModel.DataAnnotations;

namespace aspnet2.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        [System.Web.Mvc.Remote("CheckEmailExist", "Account", ErrorMessage = "Email address is already used")]
        public string UserEmailId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        public string Password { get; set; }

        [Compare("NewPassword", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "User type")]
        public int UserType { get; set; }

        public bool TermsAndConditions { get; set; }
    }
}
