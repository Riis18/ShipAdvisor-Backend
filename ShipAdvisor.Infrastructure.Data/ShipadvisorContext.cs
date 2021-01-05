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

            modelBuilder.Entity<Bid>().HasKey(b => b.Id);
            
            modelBuilder.Entity<ShipmentOrder>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.ShipmentOrders);

            modelBuilder.Entity<ShipmentOrder>()
                .HasOne(c => c.Company);

            modelBuilder.Entity<Bid>()
                .HasOne(b => b.ShipmentOrder)
                .WithMany(s => s.Bids);

            modelBuilder.Entity<Bid>()
                .HasOne(c => c.Company);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShipmentOrder> ShipmentOrders { get; set; }
        
        public DbSet<Bid> Bids { get; set; }
    }
}