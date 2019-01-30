using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Data
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }

        [Display(Name = "Area Name")]
        public DateTime CreatedDateTime { get; set; }

        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description, DateTime createdDateTome)
            : base(roleName)
        {
            this.Description = description;
            this.CreatedDateTime = createdDateTome;
        }
    }
}
