using Microsoft.EntityFrameworkCore;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data
{
    public class ShipadvisorContext: DbContext
    {
        public ShipadvisorContext(DbContextOptions opt) : base(opt)
        {
            
        }
        
        public DbSet<Customer> Customers { get; set; }
    }
}