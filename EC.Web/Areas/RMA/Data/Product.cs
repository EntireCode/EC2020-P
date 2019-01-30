using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.RMA.Data
{
    public class Product
    {
        public string Id { get; set; }

        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }

        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; }

        [Display(Name = "Basic Warranty Month(s)")]
        public int BasicWarrantyMonth { get; set; }

        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        public List<ProductSerialNumber> ProductSerialNumbers { get; set; }
    }
}
