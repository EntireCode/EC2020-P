using EC.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.RMA.Data
{
    public class RMARequest
    {
        public string Id { get; set; }

        [Display(Name="Submitted Date")]
        public DateTime SubmittedDate { get; set; }

        [Display(Name ="Submitted By")]
        public string SubmittedByUserId { get; set; }

        [Display(Name = "Submitted By User")]
        public virtual ApplicationUser SubmittedByUser { get; set; }

        [Display(Name = "RMA Report")]
        public RMAReport RMAReport { get; set; }

        [Display(Name = "Customer ERP Id")]
        public string CustomerERPId { get; set; }

        [Display(Name="Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Customer Contact")]
        public string CustomerContact { get; set; }

        [Display(Name = "Customer Contact Email")]
        public string CustomerContactEmail { get; set; }

        [Display(Name = "Invoice Number")]
        public string InvoiceNumber { get; set; }

        [Display(Name = "Model/Serial Numbers")]
        public string PartSerialNumbers { get; set; }

        [Display(Name = "Defect Phenomenon")]
        public string DefectPhenomenon { get; set; }

        [Display(Name = "Sales Person User Id")]
        public string SalesPersonUserId { get; set; }

        [Display(Name = "RMA Number")]
        public long? RMANumber { get; set; }

        [Display(Name = "RMA Issue Date")]
        [DataType(DataType.Date)]
        public DateTime? RMAIssueDate { get; set; }

        [Display(Name = "RMA Number Issued By")]
        public string RMANumberIssuedByUserId { get; set; }

        [Display(Name = "RMA Number Issued By User")]
        public virtual ApplicationUser RMANumberIssuedByUser { get; set; }

        [Display(Name = "RMA Status")]
        public RMAStatus Status { get; set; }

        [Display(Name = "RMA Closed Date")]
        public DateTime? RMAClosedDate { get; set; }

        [Display(Name = "RMA Closed By")]
        public string RMAClosedByUserId { get; set; }

        [Display(Name = "RMA Closed By User")]
        public virtual ApplicationUser RMAClosedByUser { get; set; }

        public string Remark { get; set; }

        [Display(Name = "RMA Cases")]
        public virtual List<RMACase> RMACases { get; set; }

        public virtual List<FileAttachment> Attachments { get; set; }
    }
}
