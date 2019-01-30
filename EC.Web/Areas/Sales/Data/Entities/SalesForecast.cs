using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.Areas.Sales.Data.Entities
{
    public class SalesForecast
    {
        [Key]
        public long Code { get; set; }
        public long Name { get; set; }
        [Display(Name="RSM")]
        public string USMgr { get; set; }
        [Display(Name="Rep")]
        public string USRep { get; set; }
        [Display(Name="Salesman")]
        public string USPerson { get; set; }
        [Display(Name = "Project Code")]
        public string UPj { get; set; }
        [Display(Name = "Customer Code")]
        public string UCardCode { get; set; }
        [Display(Name = "Model Name")]
        public string UModel { get; set; }
        [Display(Name = "Item Group")]
        public string UItemGroup { get; set; }
        [Display(Name = "Year")]
        public short? UYear { get; set; }
        [Display(Name = "Jan-UPrice")]
        public decimal? UJanUPrice { get; set; }
        [Display(Name = "Jan-Qty")]
        public decimal? UJan { get; set; }
        [Display(Name = "Feb-UPrice")]
        public decimal? UFebUPrice { get; set; }
        [Display(Name = "Feb-Qty")]
        public decimal? UFeb { get; set; }
        [Display(Name = "Mar-UPrice")]
        public decimal? UMarUPrice { get; set; }
        [Display(Name = "Mar-Qty")]
        public decimal? UMar { get; set; }
        [Display(Name = "Apr-UPrice")]
        public decimal? UAprUPrice { get; set; }
        [Display(Name = "Apr-Qty")]
        public decimal? UApr { get; set; }
        [Display(Name = "May-UPrice")]
        public decimal? UMayUPrice { get; set; }
        [Display(Name = "May-Qty")]
        public decimal? UMay { get; set; }
        [Display(Name = "Jun-UPrice")]
        public decimal? UJunUPrice { get; set; }
        [Display(Name = "Jun-Qty")]
        public decimal? UJun { get; set; }
        [Display(Name = "Jul-UPrice")]
        public decimal? UJulUPrice { get; set; }
        [Display(Name = "Jul-Qty")]
        public decimal? UJul { get; set; }
        [Display(Name = "Aug-UPrice")]
        public decimal? UAugUPrice { get; set; }
        [Display(Name = "Aug-Qty")]
        public decimal? UAug { get; set; }
        [Display(Name = "Sep-UPrice")]
        public decimal? USepUPrice { get; set; }
        [Display(Name = "Sep-Qty")]
        public decimal? USep { get; set; }
        [Display(Name = "Oct-UPrice")]
        public decimal? UOctUPrice { get; set; }
        [Display(Name = "Oct-Qty")]
        public decimal? UOct { get; set; }
        [Display(Name = "Nov-UPrice")]
        public decimal? UNovUPrice { get; set; }
        [Display(Name = "Nov-Qty")]
        public decimal? UNov { get; set; }
        [Display(Name = "Dec-UPrice")]
        public decimal? UDecUPrice { get; set; }
        [Display(Name = "Dec-Qty")]
        public decimal? UDec { get; set; }
        [Display(Name = "Latest Date")]
        public DateTime? ULatestDate { get; set; }
        [Display(Name = "Unit Price")]
        public decimal? UPrice { get; set; }        
    }
}
