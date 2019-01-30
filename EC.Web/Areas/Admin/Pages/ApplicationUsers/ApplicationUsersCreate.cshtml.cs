using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;

namespace EC.Web.Areas.Admin.Pages.ApplicationUsers
{
    public class ApplicationUsersCreateModel : RolesPageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<InputModel> _logger;
        private readonly IEmailSender _emailSender;

        private readonly ApplicationDbContext _context;

        public ApplicationUsersCreateModel(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<InputModel> logger,
            IEmailSender emailSender) : base(userManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        public IActionResult OnGet()
        {
            PopulateRolesPageModelModel(_context, null);

            return Page();
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "First Name")]
            public String FirstName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Last Name")]
            public String LastName { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            [Display(Name = "Created DateTime")]
            public DateTime CreatedDateTime { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "EmailConfirmed")]
            public bool EmailConfirmed { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task<IActionResult> OnPostAsync(string[] selectedRoles)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Keys.SelectMany(k => this.ModelState[k].Errors).ToList();

                return Page();
            }
            var user = new ApplicationUser
            {
                FirstName = Input.FirstName,
                LastName = Input.LastName,
                Email = Input.Email,
                UserName = Input.Email,
                CreatedDateTime = DateTime.UtcNow,
                AvatarURL = "/img/avatars/user.png"
            };

            var result = await _userManager.CreateAsync(user, Input.Password);

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = user.Id, code = code },
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                string.Format(@"Please confirm your account by <a href='{0}'>clicking here</a>.", callbackUrl));
            // update ApplicationUser EmailConfirmed value
            if (Input.EmailConfirmed)
            {
                user = _context.ApplicationUsers.FirstOrDefault(x => x.UserName == Input.Email);
                user.EmailConfirmed = Input.EmailConfirmed;
                await _context.SaveChangesAsync();
            }

            PopulateRolesPageModelModel(_context, user);

            UpdateUserRoles(_context, selectedRoles, user);

            PopulateRolesPageModelModel(_context, user);

            return RedirectToPage("./ApplicationUsersIndex")
                .WithSuccess("You are redirected!", string.Format("User: {0} created!", user.UserName));
        }
    }
}