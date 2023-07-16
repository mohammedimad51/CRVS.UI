using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRVS.Core.Models.ViewModels
{ 
    public class AddRemoveUserRoleViewModel
    {
        [DisplayName("User ID")]
        public String? UserId { get; set; }
        [DisplayName("User Name")]
        public String? UserName { get; set;} 

        [DisplayName("In Role")]
        public bool IsSelected { get; set;}
    }
}
