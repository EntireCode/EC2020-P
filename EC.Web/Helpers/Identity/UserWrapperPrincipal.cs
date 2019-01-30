using EC.Web.Data;
using EC.Web.Services.Identity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;

namespace EC.Web.Helpers.Identity
{
    public class UserWrapperPrincipal : ClaimsPrincipal
    {
        private readonly ApplicationUser _user;
        private readonly IIdentity _identity;        
        private readonly HttpContext _context;
        private readonly IUserService _userService;

        public UserWrapperPrincipal(HttpContext context, IUserService userService, ApplicationUser user, IIdentity identity)
        {
            _user = user;
            _identity = identity;
            _context = context;
            _userService = userService;
            var claimIdentities = new List<ClaimsIdentity>();
            foreach(var id in context.User.Identities)
            {
                id.AddClaims(_userService.GetClaims(_user.Id));
                claimIdentities.Add(new ClaimsIdentity(id));
            }
            AddIdentities(claimIdentities);
        }        

        public override IIdentity Identity { get { return _identity; } }

        public override bool IsInRole(string role)
        {
            return RoleNames.Contains(role);
        }

        private IList<string> RoleNames
        {
            get { return _userService.GetRoleNames(_user.Id); }
        }
    }
}
