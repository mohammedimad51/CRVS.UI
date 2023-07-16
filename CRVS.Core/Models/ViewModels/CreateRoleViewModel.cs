using System.ComponentModel.DataAnnotations;

namespace CRVS.Core.Models.ViewModels
{
    public class CreateRoleViewModel
    {
     
        [Required(ErrorMessage ="Enter Role Name")]
        [Display(Name = "Role Name")]
        public string? CreateRoleName { get; set;}
    }
}
