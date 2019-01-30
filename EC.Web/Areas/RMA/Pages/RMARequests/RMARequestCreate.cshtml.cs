using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EC.Web.Areas.RMA.Data;
using EC.Web.Areas.RMA.Data.ViewModels;
using EC.Web.Areas.Shared.Services;
using EC.Web.Data;
using EC.Web.Services.Alert;
using EC.Web.Services.Identity;
using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMARequestCreateModel : RMARequestBaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public RMARequestCreateModel(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IUserService userService,
            IB1UserService b1UserService,
            IB1CardService b1CardService,
            IB1ProductService b1ProductService) : base(userService, b1UserService, b1CardService, b1ProductService)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RMARequestViewModel RMARequest { get; set; }

        public async Task<IActionResult> OnPostSaveRequestAsync([FromBody] RMARequestViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var rmaRequest = new RMARequest
            {
                CustomerERPId = data.CustomerERPId,
                CustomerName = data.CustomerName,
                CustomerContactEmail = data.CustomerContactEmail,
                CustomerContact = data.CustomerContact,
                DefectPhenomenon = data.DefectPhenomenon,
                Remark = data.Remark,
                InvoiceNumber = data.InvoiceNumber,
                SalesPersonUserId = data.SalesPersonUserId,
                Status = data.Status,
                RMAReport = data.RMAReport,
                RMANumber = data.RMANumber,
                Attachments = new List<FileAttachment>(),
                SubmittedByUserId = user.Id,
                SubmittedDate = DateTime.UtcNow,
                RMACases = new List<RMACase>(),
            };

            // prepare partnumbers & serialnumbers
            foreach (var item in data.RMARequestItems)
            {
                if (!string.IsNullOrEmpty(item.PartNumber) && !string.IsNullOrEmpty(item.SerialNumber))
                {
                    rmaRequest.PartSerialNumbers += item.PartNumber + "," + item.SerialNumber + ";";
                }                
            }

            if (data.RMANumber != null)
            {
                if (data.RMAIssueDate == null)
                {
                    rmaRequest.RMAIssueDate = DateTime.UtcNow;
                }                
            }

            _context.RMARequests.Add(rmaRequest);
            _context.SaveChangesAsync().Wait();
            
            // Set TempData for notification manually            
            AlertViewModel alert = new AlertViewModel
            {
                AlertType = "success",
                AlertTitle = "You are redirected!",
                AlertBody = string.Format("RMAId: {0} created.", rmaRequest.Id)
            };

            TempData.Put<AlertViewModel>("alert", alert);
            return new JsonResult(string.Format("RMAId: {0} created.", rmaRequest.Id));
            //return RedirectToPage("./RMARequestsIndex")
            //    .WithSuccess("You are redirected!", 
            //    string.Format("RMAId: {0} created.", rmaRequest.Id));
        }

    }
}