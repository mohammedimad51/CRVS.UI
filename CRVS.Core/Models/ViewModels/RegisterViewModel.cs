using System.ComponentModel.DataAnnotations;

namespace CRVS.Core.Models.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        public string? UserEmail { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm not match")]
        public string? ConfirmPassword { get; set; }
        [Required]
        public string? Phone { get; set; }
        public string? UserId { get; set; }

        public string? FName { get; set; }
        public string? LName { get; set; }
            
        public string? Img { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string? Governorate { get; set; }
        public string? Doh { get; set; }
        public string? District { get; set; }
        public string? Nahia { get; set; }

        public string? Village { get; set; }
        public string? FacilityType { get; set; }
        public string? HealthInstitution { get; set; }
        public string? RoleName { get; set; }

    }
   
}
