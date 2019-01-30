using EC.Web.Data;
using EC.Web.Data.ViewModels;
using System;
using System.Collections.Generic;

namespace EC.Web.Areas.RMA.Data.ViewModels
{
    public class RMACaseViewModel
    {
        public string Id { get; set; }

        public string CustomerPartNumber { get; set; }

        public string PartNumber { get; set; }

        public int Quantity { get; set; }

        public string InvoiceNumber { get; set; }

        public WarrantyStatus WarrantyStatus { get; set; }

        public RMALocation RMALocation { get; set; }

        public string Remark { get; set; }

        public RMACaseStatus RMACaseStatus { get; set; }

        public string ProcessedByUserId { get; set; }

        public virtual ApplicationUser ProcessedByUser { get; set; }

        public DateTime ProcessedDate { get; set; }

        public string RMARequestId { get; set; }

        public virtual RMARequestViewModel RMARequest { get; set; }

        public virtual List<RMAStageViewModel> RMAStages { get; set; }

        public virtual List<FileAttachmentViewModel> Attachments { get; set; }
    }
}
