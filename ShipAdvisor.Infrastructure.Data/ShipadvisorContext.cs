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
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}