using EC.Web.Data;
using EC.Web.Data.ViewModels;
using System;
using System.Collections.Generic;

namespace EC.Web.Areas.RMA.Data.ViewModels
{
    public class RMAStageViewModel
    {
        public string Id { get; set; }

        public RMACorrectiveAction CorrectiveAction { get; set; }

        public string Note { get; set; }

        public string RMACaseId { get; set; }

        public virtual RMACaseViewModel RMACase { get; set; }

        public string SerialNumbers { get; set; }

        public string ProcessedByUserId { get; set; }

        public virtual ApplicationUser ProcessedByUser { get; set; }

        public DateTime ProcessedDate { get; set; }

        public bool IsActionDone { get; set; }

        public string CorrectiveActionNote { get; set; }

        public virtual List<FileAttachmentViewModel> Attachments { get; set; }
    }
}
