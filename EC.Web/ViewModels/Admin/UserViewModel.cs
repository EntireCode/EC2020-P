using EC.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.ViewModels.Admin
{
    public class UserViewModel : ApplicationUser
    {
        [Display(Name = "Roles Assigned")]
        public string AssignedRoles { get; set; }
    }
}
