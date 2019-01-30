using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.Examples.Data.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public CustomerViewModel Customer { get; set; }

        public virtual List<OrderItemViewModel> Items { get; set; }

        public virtual List<OrderAttachmentViewModel> Attachments { get; set; }
    }
}
