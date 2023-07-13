using System.ComponentModel.DataAnnotations;

namespace CRVS.Core.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string? UserEmail { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}