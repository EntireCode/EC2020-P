using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        [PersonalData]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [PersonalData]
        [Display(Name = "Avatar URL")]
        public string AvatarURL { get; set; }

        [Display(Name = "Created DateTime")]
        public DateTime CreatedDateTime { get; set; }
    }
}
