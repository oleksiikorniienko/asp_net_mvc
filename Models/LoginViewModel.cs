using System.ComponentModel.DataAnnotations;

namespace aspnet2.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        public string UserEmailId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public int UserType { get; set; }
    }
}
