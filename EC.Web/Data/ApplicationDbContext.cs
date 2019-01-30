using EC.Web.Areas.RMA.Data;
using EC.Web.Areas.Sales.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);           
            builder.Entity<RMARequest>()
                .HasMany(r => r.RMACases)                
                .WithOne(r => r.RMARequest)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<RMACase>()
                .HasMany(r => r.RMAStages)
                .WithOne(r => r.RMACase)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ApplicationRole> ApplicationRoles { get; set; }

        public DbSet<ApplicationMenu> ApplicationMenus { get; set; }

        public DbSet<ApplicationRoleMenu> ApplicationRoleMenus { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductSerialNumber> ProductSerialNumbers { get; set; }

        public DbSet<RMARequest> RMARequests { get; set; }

        public DbSet<RMACase> RMACases { get; set; }

        public DbSet<RMAStage> RMAStages { get; set; }

        public DbSet<RMANumber> RMANumbers { get; set; }

        public DbSet<FileAttachment> FileAttachments { get; set; }
        //public DbSet<RMARequestDetail> RMARequestDetails { get; set; }

        public DbSet<SalesForecast> SalesForecasts { get; set; }
    }
}
