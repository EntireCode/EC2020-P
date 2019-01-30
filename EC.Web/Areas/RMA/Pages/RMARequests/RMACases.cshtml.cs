using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EC.Web.Areas.RMA.Data;
using EC.Web.Areas.RMA.Data.ViewModels;
using EC.Web.Areas.Shared.Services;
using EC.Web.Data;
using EC.Web.Services.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMACasesModel : RMARequestBaseModel
    {
        public readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public RMACasesModel(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IUserService userService,
            IB1UserService b1UserService,
            IB1CardService b1CardService,
            IB1ProductService b1ProductService) : base(userService, b1UserService, b1CardService, b1ProductService)
        {
            _context = context;
            _userManager = userManager;
        }

        public RMARequestViewModel RMARequest { get; set; }

        //public void OnGet(string id)
        //{            
        //    var data = _context.RMARequests
        //        .Include(x => x.RMACases)
        //        .Include(x => x.Attachments)                
        //        .Where(x => x.Id == id).FirstOrDefault();
        //    RMARequest = new RMARequestViewModel
        //    {
        //        Id = data.Id,
        //        CustomerERPId = data.CustomerERPId,
        //        CustomerContact = data.CustomerContact,
        //        CustomerName = data.CustomerName,
        //        CustomerContactEmail = data.CustomerContactEmail,
        //        DefectPhenomenon = data.DefectPhenomenon,
        //        InvoiceNumber = data.InvoiceNumber,
        //        Remark = data.Remark,
        //        RMAIssueDate = data.RMAIssueDate,
        //        RMANumber = data.RMANumber,
        //        SubmittedByUserId = data.SubmittedByUserId,
        //        SubmittedDate = data.SubmittedDate,
        //        Status = data.Status,
        //        SalesPersonUserId = data.SalesPersonUserId,
        //        Attachments = new List<Web.Data.ViewModels.FileAttachmentViewModel>(),
        //        RMACases = new List<RMACaseViewModel>()
        //    };

        //    foreach(var c in data.RMACases)
        //    {
        //        RMARequest.RMACases.Add(new RMACaseViewModel
        //        {
        //            Id = c.Id,
        //            CustomerPartNumber = c.CustomerPartNumber,
        //            InvoiceNumber = c.InvoiceNumber,
        //            PartNumber = c.PartNumber,
        //            Quantity = c.Quantity,
        //            Remark = c.Remark,
        //            RMALocation = c.RMALocation,
        //            RMARequestId = c.RMARequestId,
        //            SerialNumbers = c.SerialNumbers,
        //            Attachments = new List<Web.Data.ViewModels.FileAttachmentViewModel>(),
        //            RMAStages = GetStages(c.Id),
        //            RMACaseStatus = c.RMACaseStatus,
        //            WarrantyStatus = c.WarrantyStatus
        //        });
        //    }
        //}

        private List<RMAStageViewModel> GetStages(string rmaCaseId)
        {
            var result = new List<RMAStageViewModel>();
            var stages = _context.RMAStages.Where(x => x.RMACaseId == rmaCaseId).ToList();
            foreach(var stage in stages)
            {
                result.Add(new RMAStageViewModel
                {
                    Id = stage.Id,
                    RMACaseId = stage.RMACaseId,
                    Note = stage.Note,
                    CorrectiveAction = stage.CorrectiveAction,
                    CorrectiveActionNote = stage.CorrectiveActionNote,
                    IsActionDone = stage.IsActionDone,
                    ProcessedByUserId = stage.ProcessedByUserId,
                    ProcessedDate = stage.ProcessedDate
                });
            }
            return result;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RMARequest, RMARequestViewModel>();
                cfg.CreateMap<RMACase, RMACaseViewModel>();
            });

            IMapper mapper = config.CreateMapper();

            var rmaRequest = await _context.RMARequests
                .Include(x => x.RMACases)
                .Include(x => x.Attachments)
                .Include(x => x.SubmittedByUser)
                .Select(x => mapper.Map<RMARequest, RMARequestViewModel>(x))
                .FirstOrDefaultAsync(m => m.Id == id);

            rmaRequest.RMARequestItems = new List<RMARequestItemViewModel>();
            var partSerialNumbers = rmaRequest.PartSerialNumbers.Split(';');

            foreach (var partSerialNumber in partSerialNumbers)
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

            rmaRequest.RMACases = new List<RMACaseViewModel>();
            var rmaCases = _context.RMACases.Where(x => x.RMARequestId == id)
                .Include(x => x.RMARequest)
                .Include(x => x.ProcessedByUser)
                .Include(x => x.RMAStages)
                .Select(x => mapper.Map<RMACase, RMACaseViewModel>(x))
                .ToList();
            rmaRequest.RMACases = rmaCases;
            
            if (rmaRequest == null)
            {
                return NotFound();
            }

            RMARequest = rmaRequest;

            return Page();
        }

        public async Task<IActionResult> OnPostSaveCasesAsync([FromBody] RMARequestViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = "Error! Saving RMA Cases not completed.";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            foreach (var detail in data.RMACases)
            {
                if (string.IsNullOrEmpty(detail.Id))
                {
                    var rmaCase = new RMACase
                    {
                        //Id = detail.Id,
                        RMARequestId = data.Id,
                        CustomerPartNumber = detail.CustomerPartNumber,
                        PartNumber = detail.PartNumber,
                        Quantity = detail.Quantity,
                        InvoiceNumber = detail.InvoiceNumber,
                        WarrantyStatus = detail.WarrantyStatus,
                        RMALocation = detail.RMALocation,
                        Remark = detail.Remark,
                        RMACaseStatus = detail.RMACaseStatus,
                        ProcessedByUserId = user.Id,
                        ProcessedDate = DateTime.UtcNow,
                        RMAStages = new List<RMAStage>(),
                        Attachments = new List<FileAttachment>()
                    };
                    _context.RMACases.Add(rmaCase);
                }
                else
                {
                    var rmaCase = _context.RMACases.FirstOrDefault(x => x.Id == detail.Id);
                    rmaCase.InvoiceNumber = detail.InvoiceNumber;
                    rmaCase.CustomerPartNumber = detail.CustomerPartNumber;
                    rmaCase.PartNumber = detail.PartNumber;
                    rmaCase.Quantity = detail.Quantity;
                    rmaCase.Remark = detail.Remark;
                    rmaCase.RMACaseStatus = detail.RMACaseStatus;
                    rmaCase.RMALocation = detail.RMALocation;
                    rmaCase.WarrantyStatus = detail.WarrantyStatus;
                    rmaCase.ProcessedByUserId = user.Id;
                    rmaCase.ProcessedDate = DateTime.UtcNow;
                }
            }
            // remove original cases not included in this post
            var cases = _context.RMACases.Where(x => x.RMARequestId == data.Id).ToList();
            foreach(var c in cases)
            {
                if (!data.RMACases.Any(x => x.Id == c.Id))
                {
                    _context.RMACases.Remove(c);
                }
            }
            _context.SaveChanges();

            result = "Success! Save RMA Cases are completed.";

            return new JsonResult(result);
        }
    }
}