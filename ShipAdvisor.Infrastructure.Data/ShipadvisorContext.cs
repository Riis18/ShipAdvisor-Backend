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

            modelBuilder.Entity<ShipmentOrder>().HasKey(s => s.Id);
            
            modelBuilder.Entity<ShipmentOrder>()
                .HasMany(s => s.Customers)
                .WithMany(c => c.ShipmentOrders);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShipmentOrder> ShipmentOrders { get; set; }
    }
}