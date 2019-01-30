using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EC.Web.Areas.RMA.Data;
using EC.Web.Areas.RMA.Data.ViewModels;
using EC.Web.Areas.Shared.Services;
using EC.Web.Data;
using EC.Web.Services.Alert;
using EC.Web.Services.Identity;
using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMARequestEditModel : RMARequestBaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IUserService _userService;
        private readonly IB1UserService _b1UserService;
        private readonly IB1ProductService _b1ProductService;
        private readonly IB1CardService _b1CardService;

        public RMARequestEditModel(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IUserService userService,
            IB1UserService b1UserService,
            IB1CardService b1CardService,
            IB1ProductService b1ProductService) : base(userService, b1UserService, b1CardService, b1ProductService)
        {
            _context = context;
            _userManager = userManager;
            _userService = userService;
            _b1UserService = b1UserService;
            _b1ProductService = b1ProductService;
            _b1CardService = b1CardService;
        }

        [BindProperty]
        public RMARequestViewModel RMARequest { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RMARequest, RMARequestViewModel>();
            });

            IMapper mapper = config.CreateMapper();

            var rmaRequest = await _context.RMARequests
                .Include(x => x.RMACases)
                .Include(x => x.Attachments)
                .Include(x => x.SubmittedByUser)
                .Include(x => x.RMANumberIssuedByUser)
                .Include(x => x.RMAClosedByUser)
                .Select(x => mapper.Map<RMARequest, RMARequestViewModel>(x))
                .FirstOrDefaultAsync(m => m.Id == id);

            rmaRequest.RMARequestItems = new List<RMARequestItemViewModel>();            
            var partSerialNumbers = rmaRequest.PartSerialNumbers.Split(';');
            
            foreach(var partSerialNumber in partSerialNumbers)
            {
                if (!string.IsNullOrEmpty(partSerialNumber))
                {
                    var keyPair = partSerialNumber.Split(',');
                    rmaRequest.RMARequestItems.Add(new RMARequestItemViewModel
                    {
                        PartNumber = keyPair[0],
                        SerialNumber = keyPair[1]
                    });
                }
            }

            if (rmaRequest == null)
            {
                return NotFound();
            }

            RMARequest = rmaRequest;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (RMARequest.RMANumber != null)
            {
                if (RMARequest.RMAIssueDate == null)
                {
                    RMARequest.RMAIssueDate = DateTime.UtcNow;
                }
            }
            _context.Attach(RMARequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RMACaseExists(RMARequest.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./RMARequestsIndex").WithSuccess("You are redirected!", string.Format("RMA Number: {0} with Id: {1} modified successfully.", RMARequest.RMANumber, RMARequest.Id));
        }

        private bool RMACaseExists(string id)
        {
            return _context.RMARequests.Any(e => e.Id == id);
        }

        public async Task<IActionResult> OnPostSaveRequestAsync([FromBody] RMARequestViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var rmaRequest = _context.RMARequests.FirstOrDefault(x => x.Id == data.Id);

            rmaRequest.CustomerERPId = data.CustomerERPId;
            rmaRequest.CustomerName = data.CustomerName;
            rmaRequest.CustomerContactEmail = data.CustomerContactEmail;
            rmaRequest.DefectPhenomenon = data.DefectPhenomenon;
            rmaRequest.CustomerContact = data.CustomerContact;
            rmaRequest.InvoiceNumber = data.InvoiceNumber;
            rmaRequest.Remark = data.Remark;            
            //rmaRequest.Status = data.Status;
            rmaRequest.RMAReport = data.RMAReport;
            rmaRequest.SalesPersonUserId = data.SalesPersonUserId;

            if (rmaRequest.RMANumber == null && data.RMANumber != null)
            {
                rmaRequest.RMANumber = data.RMANumber;
                rmaRequest.RMANumberIssuedByUserId = user.Id;
                rmaRequest.RMAIssueDate = DateTime.UtcNow;
            }

            // prepare partnumbers & serialnumbers
            rmaRequest.PartSerialNumbers = string.Empty;
            foreach (var item in data.RMARequestItems)
            {
                if (!string.IsNullOrEmpty(item.PartNumber) && !string.IsNullOrEmpty(item.SerialNumber))
                {
                    rmaRequest.PartSerialNumbers += item.PartNumber + "," + item.SerialNumber + ";";
                }
            }

            _context.SaveChanges();

            // Set TempData for notification manually            
            AlertViewModel alert = new AlertViewModel
            {
                AlertType = "success",
                AlertTitle = "You are redirected!",
                AlertBody = string.Format("RMA Number: {0} with Id: {1} modified successfully.", rmaRequest.RMANumber, rmaRequest.Id)
            };
            
            TempData.Put<AlertViewModel>("alert", alert);
            return new JsonResult(string.Format("RMA Number: {0} with Id: {1} modified successfully.", rmaRequest.RMANumber, rmaRequest.Id));
        }

        public async Task<IActionResult> OnPostCloseRMAAsync([FromBody] RMARequestViewModel data)
        {
            var id = data.Id;
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var rmaRequest = _context.RMARequests.Include(x => x.RMACases)
                .FirstOrDefault(x => x.Id == id && x.Status != RMAStatus.Closed);

            if (rmaRequest == null)
            {
                return NotFound();
            }

            if (rmaRequest.RMACases.Count == 0)
            {
                return NotFound();
            }

            bool isValidToClose = true;

            foreach(var rmaCase in rmaRequest.RMACases)
            {
                var stages = _context.RMAStages.Where(x => x.RMACaseId == rmaCase.Id).ToList();
                    
                foreach(var stage in stages)
                {
                    isValidToClose = stage.IsActionDone;
                    if (!isValidToClose) break;
                }
                if (!isValidToClose) break;
            }

            AlertViewModel alert = new AlertViewModel();

            if (isValidToClose)
            {
                rmaRequest.Status = RMAStatus.Closed;
                rmaRequest.RMAClosedDate = DateTime.UtcNow;
                rmaRequest.RMAClosedByUserId = user.Id;
                _context.SaveChanges();
            }
            else
            {
                // Set TempData for notification manually            
                alert = new AlertViewModel
                {
                    AlertType = "warning",
                    AlertTitle = "You have not done stage.",
                    AlertBody = string.Format("RMA Number: {0} with Id: {1} modified failed.", rmaRequest.RMANumber, rmaRequest.Id)
                };

                return NotFound();
            }

            // Set TempData for notification manually            
            alert = new AlertViewModel
            {
                AlertType = "success",
                AlertTitle = "You are redirected!",
                AlertBody = string.Format("RMA Number: {0} with Id: {1} modified successfully.", rmaRequest.RMANumber, rmaRequest.Id)
            };

            TempData.Put<AlertViewModel>("alert", alert);
            return new JsonResult(string.Format("RMA Number: {0} with Id: {1} modified successfully.", rmaRequest.RMANumber, rmaRequest.Id));
        }
    }
}