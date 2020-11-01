using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ShipadvisorContext _ctx;

        public CustomerRepository(ShipadvisorContext ctx)
        {
            _ctx = ctx;
        }
        public Customer Create(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _ctx.Customers;
        }
        
    }
}