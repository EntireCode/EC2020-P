using EC.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.RMA.Data
{
    public class RMAStage
    {
        public string Id { get; set; }

        [Display(Name = "Corrective Action")]
        public RMACorrectiveAction CorrectiveAction { get; set; }

        public string Note { get; set; }

        [Display(Name = "RMA Case Id")]
        public string RMACaseId { get; set; }

        [Display(Name = "RMA Case")]
        public virtual RMACase RMACase { get; set; }

        [Display(Name = "Serial Numbers")]
        public string SerialNumbers { get; set; }

        [Display(Name = "Processed By User Id")]
        public string ProcessedByUserId { get; set; }

        [Display(Name = "Processed By User")]
        public virtual ApplicationUser ProcessedByUser { get; set; }

        [Display(Name = "Processed Date")]
        public DateTime ProcessedDate { get; set; }

        [Display(Name = "Action Done?")]
        public bool IsActionDone { get; set; }

        [Display(Name = "Corrective Action Note")]
        public string CorrectiveActionNote { get; set; }

        public virtual List<FileAttachment> Attachments { get; set; }
    }
}
