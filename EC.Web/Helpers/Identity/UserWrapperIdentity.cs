using EC.Web.Data;
using EC.Web.Services.Identity;
using System.Collections.Generic;
using System.Security.Claims;

namespace EC.Web.Helpers.Identity
{
    public class UserWrapperIdentity : System.Security.Principal.GenericIdentity
    {
        private readonly IUserService _userService;

        public UserWrapperIdentity(IUserService userService, ApplicationUser authUser) : base(authUser.UserName)
        {
            _userService = userService;
            List<Claim> claims = _userService.GetClaims(authUser.Id);
            AddClaims(claims);
        }
    }
}
