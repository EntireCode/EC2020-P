using System;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.Sales.Data.ViewModels
{
    public class WeeklyBacklogViewModel
    {
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrdDate { get; set; }

        [Display(Name = "SO#")]
        public int SONumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ship Date")]
        public DateTime ShipDate { get; set; }

        public string Sales { get; set; }

        [Display(Name = "Inside Sales")]
        public string InsideSales { get; set; }

        public string Rep { get; set; }

        [Display(Name = "Rep Comm")]
        public decimal? RepComm { get; set; }

        public string Customer { get; set; }

        [Display(Name = "Cust PO#")]
        public string CustPONumber { get; set; }

        public int Ln { get; set; }

        [Display(Name = "Model#")]
        public string ModelNumber { get; set; }

        [Display(Name = "Open Qty")]
        public decimal? OpenQty { get; set; }

        public decimal? Price { get; set; }

        [Display(Name = "Open Amt")]
        public Int32 OpenAmt { get; set; }

        public string Notes { get; set; }
    }
}
