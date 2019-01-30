using EC.Web.Areas.Examples.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.Services.Examples
{
    public class ExamplesRepository : IExamplesRepository
    {
        public ExamplesRepository()
        {
            Customers = new List<Customer>();
            Customers.Add(new Customer { Id = 1, CustomerName = "Microsoft" });
            Customers.Add(new Customer { Id = 2, CustomerName = "Apple" });
            Customers.Add(new Customer { Id = 3, CustomerName = "Google" });
            Customers.Add(new Customer { Id = 4, CustomerName = "Facebook" });
            Products = new List<Product>();
            Products.Add(new Product { Id = 1, PartNo = "iPro11-128", ProductDescription = "iPad Pro 11 125GB", UnitPrice = 769 });
            Products.Add(new Product { Id = 2, PartNo = "iPro11-256", ProductDescription = "iPad Pro 11 256GB", UnitPrice = 869 });
            Products.Add(new Product { Id = 3, PartNo = "iPro11-512", ProductDescription = "iPad Pro 11 512GB", UnitPrice = 969 });
            Products.Add(new Product { Id = 4, PartNo = "iPro12-128", ProductDescription = "iPad Pro 12 125GB", UnitPrice = 869 });
            Products.Add(new Product { Id = 5, PartNo = "iPro12-256", ProductDescription = "iPad Pro 12 256GB", UnitPrice = 969 });
            Products.Add(new Product { Id = 6, PartNo = "iPro12-512", ProductDescription = "iPad Pro 12 512GB", UnitPrice = 1069 });
            Orders = new List<Order>();
            Orders.Add(new Order {
                Id = 1,
                OrderDate = DateTime.Parse("12/1/2018"),
                CustomerId = 1,
                Items = new List<OrderItem>
                {
                    new OrderItem { Id = 1, ItemNo = 1, OrderId = 1, ProductId = 1, Quantity = 1},
                    new OrderItem { Id = 2, ItemNo = 2, OrderId = 1, ProductId = 2, Quantity = 1},
                }
            });
            Orders.Add(new Order
            {
                Id = 2,
                OrderDate = DateTime.Parse("12/11/2018"),
                CustomerId = 1,
                Items = new List<OrderItem>
                {
                    new OrderItem { Id = 3, ItemNo = 1, OrderId = 2, ProductId = 3, Quantity = 1},
                    new OrderItem { Id = 4, ItemNo = 2, OrderId = 2, ProductId = 4, Quantity = 1},
                }
            });
            OrderAttachments = new List<OrderAttachment>();
        }

        public List<Order> Orders { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public List<Product> Products { get; set; }

        public List<Customer> Customers { get; set; }

        public List<OrderAttachment> OrderAttachments { get; set; }
    }
}
