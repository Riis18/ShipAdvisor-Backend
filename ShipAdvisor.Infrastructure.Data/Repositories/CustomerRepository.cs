using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
        

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _ctx.Customers;
        }

        public Customer CreateCustomer(Customer customer)
        {
            var customerSaved = _ctx.Customers.Add(customer).Entity;
            _ctx.SaveChanges();
            return customerSaved;
        }
        
    }
}