using EC.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.RMA.Data
{
    public class RMACase
    {
        public string Id { get; set; }

        [Display(Name = "Customer Part Number")]
        public string CustomerPartNumber { get; set; }

        [Display(Name = "Invoice Number")]
        public string InvoiceNumber { get; set; }

        [Display(Name = "Model Number")]
        public string PartNumber { get; set; }

        [Display(Name = "Warranty Status")]
        public WarrantyStatus WarrantyStatus { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "RMA Location")]
        public RMALocation RMALocation { get; set; }

        [Display(Name = "Processed By User Id")]
        public string ProcessedByUserId { get; set; }

        [Display(Name = "Processed By User")]
        public virtual ApplicationUser ProcessedByUser { get; set; }

        [Display(Name = "Processed Date")]
        public DateTime ProcessedDate { get; set; }

        public string Remark { get; set; }

        [Display(Name = "RMA Case Status")]
        public RMACaseStatus RMACaseStatus { get; set; }

        [Display(Name = "RMA Request Id")]
        public string RMARequestId { get; set; }

        [Display(Name = "RMA Request")]
        public virtual RMARequest RMARequest { get; set; }

        [Display(Name = "RMA Stages")]
        public virtual List<RMAStage> RMAStages { get; set; }

        public virtual List<FileAttachment> Attachments { get; set; }
    }
}
