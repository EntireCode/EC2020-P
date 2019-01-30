//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EC.Web.Areas.RMA.Data
//{
//    public class RMARequest
//    {
//        public string Id { get; set; }

//        [Display(Name="Created Date")]
//        public DateTime CreatedDate { get; set; }

//        [Display(Name="Customer Name")]
//        public string CustomerName { get; set; }

//        [Display(Name = "Customer Contact Email")]
//        public string CustomerContactEmail { get; set; }

//        [Display(Name = "Customer Contact")]
//        public string CustomerContact { get; set; }

//        [Display(Name = "Invoice Number")]
//        public string InvoiceNumber { get; set; }

//        [Display(Name = "Model Number")]
//        public string ModelNumber { get; set; }

//        [Display(Name = "Customer Part Number")]
//        public string CustomerPartNumber { get; set; }

//        [Display(Name = "Serial Number")]
//        public string SerialNumber { get; set; }

//        [Display(Name = "Defect Phenomenon")]
//        public string DefectPhenomenon { get; set; }

//        [Display(Name = "RMA Number")]
//        public int RMANumber { get; set; }

//        [Display(Name = "RMA Issue Date")]
//        public DateTime RMAIssueDate { get; set; }

//        public string SalesPerson { get; set; }

//        public RMALocation RMALocation { get; set; }

//        [Display(Name = "Warranty Status")]
//        public WarrantyStatus WarrantyStatus { get; set; }

//        [Display(Name = "RMA Status")]
//        public RMAStatus Status { get; set; }

//        [Display(Name = "Return Description")]
//        public string ReturnDescription { get; set; }

//        [Display(Name = "RMA Complete Date")]
//        public DateTime RMACompleteDate { get; set; }

//        [Display(Name = "Corrective Action")]
//        public string CorrectiveAction { get; set; }

//        [Display(Name = "Failure Analysis")]
//        public string FailureAnalysis { get; set; }

//        [Display(Name = "8D Report")]
//        public string EightDReport { get; set; }

//        [Display(Name = "FA/8D Report")]        
//        public string FAEightDReport { get; set; }

//        [Display(Name = "FA/8D Complete Date")]
//        public DateTime FAEightDCompleteDate { get; set; }

//        public string Remark { get; set; }
//    }
//}
