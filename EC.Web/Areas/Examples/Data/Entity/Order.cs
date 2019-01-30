using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.Examples.Data.Entity
{
    public class Order
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public virtual List<OrderItem> Items { get; set; }

        public virtual List<OrderAttachment> Attachments { get; set; }
    }
}
