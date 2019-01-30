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
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMAStagesModel : RMARequestBaseModel
    {
        public readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public RMAStagesModel(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            IUserService userService,
            IB1UserService b1UserService,
            IB1CardService b1CardService,
            IB1ProductService b1ProductService) : base(userService, b1UserService, b1CardService, b1ProductService)
        {
            _context = context;
            _userManager = userManager;
        }

        public RMAStatus RMARequestStatus { get; set; }

        public RMACaseViewModel RMACase { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RMACase, RMACaseViewModel>();
                cfg.CreateMap<RMAStage, RMAStageViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            RMACase = _context.RMACases
                .Include(x => x.ProcessedByUser)
                .Include(x => x.RMAStages)
                .Select(x => mapper.Map<RMACase, RMACaseViewModel>(x))
                .Where(x => x.Id == id).FirstOrDefault();

            RMARequestStatus = _context.RMARequests.FirstOrDefault(x => x.Id == RMACase.RMARequestId).Status;
            //RMACase = new RMACaseViewModel
            //{
            //    Id = id,
            //    Attachments = new List<Web.Data.ViewModels.FileAttachmentViewModel>(),
            //    CustomerPartNumber = data.CustomerPartNumber,
            //    InvoiceNumber = data.InvoiceNumber,
            //    PartNumber = data.PartNumber,
            //    Quantity = data.Quantity,
            //    Remark = data.Remark,
            //    RMACaseStatus = data.RMACaseStatus,
            //    RMALocation = data.RMALocation,
            //    RMARequestId = data.RMARequestId,
            //    RMAStages = new List<RMAStageViewModel>(),
            //    WarrantyStatus = data.WarrantyStatus
            //};            

            if (RMACase == null)
            {
                return NotFound();
            }

            //foreach(var stage in RMACase.RMAStages)
            //{
            //    RMACase.RMAStages.Add(new RMAStageViewModel
            //    {
            //        Id = stage.Id,
            //        Attachments = new List<Web.Data.ViewModels.FileAttachmentViewModel>(),                   
            //        Note = stage.Note,
            //        RMACaseId = stage.RMACaseId,
            //        SerialNumbers = stage.SerialNumbers,
            //        CorrectiveAction = stage.CorrectiveAction,
            //        CorrectiveActionNote = stage.CorrectiveActionNote,
            //        IsActionDone = stage.IsActionDone,
            //        ProcessedByUserId = stage.ProcessedByUserId,
            //        ProcessedByUser = stage.ProcessedByUser,
            //        ProcessedDate = stage.ProcessedDate                    
            //    });
            //}

            return Page();
        }

        public async Task<ActionResult> OnPostSaveStages([FromBody] RMACaseViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            var result = "Error! Saving RMA Stages completed.";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            foreach (var stage in data.RMAStages)
            {
                if (string.IsNullOrEmpty(stage.Id))
                {                    
                    var rmaStage = new RMAStage
                    {
                        RMACaseId = stage.RMACaseId,
                        SerialNumbers = stage.SerialNumbers,
                        Note = stage.Note,
                        ProcessedByUserId = user.Id,
                        ProcessedDate = DateTime.UtcNow,
                        CorrectiveAction = stage.CorrectiveAction,
                        CorrectiveActionNote = stage.CorrectiveActionNote,
                        IsActionDone = stage.IsActionDone,
                        Attachments = new List<FileAttachment>()
                    };
                    _context.RMAStages.Add(rmaStage);
                }
                else
                {
                    var rmaStage = _context.RMAStages.FirstOrDefault(x => x.Id == stage.Id);
                    rmaStage.RMACaseId = stage.RMACaseId;
                    rmaStage.Note = stage.Note;
                    rmaStage.CorrectiveAction = stage.CorrectiveAction;
                    rmaStage.CorrectiveActionNote = stage.CorrectiveActionNote;
                    rmaStage.IsActionDone = stage.IsActionDone;
                }
            }
            // remove original stages not included in this post
            var stages = _context.RMAStages.Where(x => x.RMACaseId == data.Id).ToList();
            foreach(var s in stages)
            {
                if (!data.RMAStages.Any(x => x.Id == s.Id))
                {
                    _context.RMAStages.Remove(s);
                }
            }
            _context.SaveChanges();

            result = "Success! Save RMA Stages are completed.";

            return new JsonResult(result);
        }
    }
}