using System;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.RMA.Data
{
    public class ProductSerialNumber
    {
        public string Id { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name = "Warranty Start From")]
        public DateTime WarrantyStartFromDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Warranty Expiration")]
        public DateTime WarrantyExpireDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
