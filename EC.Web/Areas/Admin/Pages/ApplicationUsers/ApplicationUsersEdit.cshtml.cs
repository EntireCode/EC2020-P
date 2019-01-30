using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EC.Web.Areas.Admin.Pages.ApplicationUsers
{
    public class ApplicationUsersEditModel : RolesPageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<ApplicationUser> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public ApplicationUsersEditModel(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<ApplicationUser> logger,
            IEmailSender emailSender) : base(userManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationUser = await _context.ApplicationUsers.FirstOrDefaultAsync(m => m.Id == id);

            if (ApplicationUser == null)
            {
                return NotFound();
            }

            PopulateRolesPageModelModel(_context, ApplicationUser);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string[] selectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = Get(ApplicationUser.Id);

            if (user == null)
            {
                return NotFound();
            }

            if (user.FirstName != ApplicationUser.FirstName)
                user.FirstName = ApplicationUser.FirstName;

            if (user.LastName != ApplicationUser.LastName)
                user.LastName = ApplicationUser.LastName;

            if (user.Email != ApplicationUser.Email)
            {
                user.Email = ApplicationUser.Email;
                user.NormalizedEmail = ApplicationUser.Email.ToUpper();
            }

            if (user.UserName != ApplicationUser.UserName)
            {
                user.UserName = ApplicationUser.UserName;
                user.NormalizedUserName = ApplicationUser.UserName.ToUpper();
            }

            if (user.EmailConfirmed != ApplicationUser.EmailConfirmed)
            {
                user.EmailConfirmed = ApplicationUser.EmailConfirmed;
            }

            _context.Attach(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!ApplicationUserExists(ApplicationUser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            PopulateRolesPageModelModel(_context, user);

            UpdateUserRoles(_context, selectedRoles, user);

            PopulateRolesPageModelModel(_context, user);

            return RedirectToPage("./ApplicationUsersIndex")
                .WithSuccess("You are redirected!", string.Format("User: {0} with Id {1} modified successfully!", ApplicationUser.UserName, ApplicationUser.Id)); ;
        }

        private bool ApplicationUserExists(string id)
        {
            return _context.ApplicationUsers.Any(e => e.Id == id);
        }

        private ApplicationUser Get(string id)
        {
            return _context.ApplicationUsers.FirstOrDefault(x => x.Id == id);
        }
    }
}