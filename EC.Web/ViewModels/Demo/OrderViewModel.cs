using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.ViewModels.Demo
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public string Customer { get; set; }

        public virtual List<OrderDetailViewModel> Details { get; set; }

        public virtual List<OrderAttachmentViewModel> Attachments { get; set; }
    }

    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }

        public virtual OrderViewModel Order { get; set; }

        public int ItemNo { get; set; }

        public string PartNo { get; set; }

        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

        public int Amount { get { return UnitPrice * Quantity; } }
    }

    public class OrderAttachmentViewModel
    {
        public int OrderId { get; set; }

        public virtual OrderViewModel Order { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }
    }
}
