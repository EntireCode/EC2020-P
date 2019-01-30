using EC.Web.Data;
using EC.Web.Data.ViewModels;
using System;
using System.Collections.Generic;

namespace EC.Web.Areas.RMA.Data.ViewModels
{
    public class RMARequestViewModel
    {
        public string Id { get; set; }

        public DateTime SubmittedDate { get; set; }

        public string SubmittedByUserId { get; set; }

        public virtual ApplicationUser SubmittedByUser { get; set; }

        public string CustomerERPId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerContact { get; set; }

        public string CustomerContactEmail { get; set; }

        public string InvoiceNumber { get; set; }

        public string PartSerialNumbers { get; set; }

        public List<RMARequestItemViewModel> RMARequestItems { get; set; }

        public string DefectPhenomenon { get; set; }

        public string SalesPersonUserId { get; set; }

        public long? RMANumber { get; set; }

        public DateTime? RMAIssueDate { get; set; }

        public string RMANumberIssuedByUserId { get; set; }

        public virtual ApplicationUser RMANumberIssuedByUser { get; set; }

        public RMAStatus Status { get; set; }

        public DateTime? RMAClosedDate { get; set; }

        public string RMAClosedByUserId { get; set; }

        public virtual ApplicationUser RMAClosedByUser { get; set; }

        public RMAReport RMAReport { get; set; }

        public string Remark { get; set; }

        public virtual List<RMACaseViewModel> RMACases { get; set; }

        public virtual List<FileAttachmentViewModel> Attachments { get; set; }
    }

    public class RMARequestItemViewModel
    {
        public string PartNumber { get; set; }

        public string SerialNumber { get; set; }
    }
}
