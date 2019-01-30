using EC.Web.Areas.Examples.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EC.Web.Services.Examples
{
    public interface IExamplesRepository
    {
        List<Order> Orders { get; set; }

        List<OrderItem> OrderItems { get; set; }

        List<Product> Products { get; set; }

        List<Customer> Customers { get; set; }

        List<OrderAttachment> OrderAttachments { get; set; }
    }
}
