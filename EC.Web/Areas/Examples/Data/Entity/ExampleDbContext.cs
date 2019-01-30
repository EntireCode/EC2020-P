using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Examples.Data.Entity
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
            : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderAttachment> OrderAttachments { get; set; }
    }
}
