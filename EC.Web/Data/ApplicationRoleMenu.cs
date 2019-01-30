using System.ComponentModel.DataAnnotations;

namespace EC.Web.Data
{
    public class ApplicationRoleMenu
    {
        public string Id { get; set; }

        [Required]
        public string RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }

        [Required]
        public string MenuId { get; set; }

        public virtual ApplicationMenu Menu { get; set; }
    }
}
