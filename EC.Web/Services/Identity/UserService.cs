using EC.Web.Areas.Shared.Data.ViewModels;
using EC.Web.Data;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace EC.Web.Services.Identity
{
    public interface IUserService
    {
        List<Claim> GetClaims(string userName);
        List<string> GetRoleNames(string userId);
        List<UserSelectListViewModel> GetUsers(string claimType, string claimValue);
    }

    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Claim> GetClaims(string userId)
        {
            var identityUserClaims = _context.UserClaims.Where(x => x.UserId == userId).ToList();
            var claims = new List<Claim>();
            foreach(var claim in identityUserClaims)
            {
                claims.Add(new Claim(claim.ClaimType, claim.ClaimValue));
            }

            return claims;
        }

        public List<string> GetRoleNames(string userId)
        {
            var roles = (from ur in _context.UserRoles.Where(x => x.UserId == userId)
                         join r in _context.Roles on ur.RoleId equals r.Id
                         select r.Name).ToList();
            return roles;
        }

        public List<UserSelectListViewModel> GetUsers(string claimType, string claimValue)
        {
            var data = (from u in _context.Users
                        join uc in _context.UserClaims on u.Id equals uc.UserId
                        where uc.ClaimType == claimType && uc.ClaimValue == claimValue
                        select new UserSelectListViewModel
                        {
                            Id = u.Id,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                        }).ToList();

            return data;
        }
    }
}
