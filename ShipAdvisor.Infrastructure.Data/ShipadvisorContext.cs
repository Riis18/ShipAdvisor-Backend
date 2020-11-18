using Microsoft.EntityFrameworkCore;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data
{
    public class ShipadvisorContext: DbContext
    {
        public ShipadvisorContext(DbContextOptions<ShipadvisorContext> opt)
            : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasKey(c => c.UId);
            
            modelBuilder.Entity<ShipmentOrder>()
                .HasMany(s => s.Customers)
                .WithMany(c => c.ShipmentOrders);

            modelBuilder.Entity<PackageList>()
                .HasOne(p => p.ShipmentOrder)
                .WithMany(s => s.PackageLists)
                .OnDelete(DeleteBehavior.SetNull);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShipmentOrder> ShipmentOrders { get; set; }
        public DbSet<PackageList> PackageLists { get; set; }
    }
}