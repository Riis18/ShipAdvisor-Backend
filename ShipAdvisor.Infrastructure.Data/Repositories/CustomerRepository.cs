using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;
using ShipAdvisor.Infrastructure.Data.Managers;

namespace ShipAdvisor.Infrastructure.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ShipadvisorContext _ctx;
        private FirebaseManager _firebase;

        public CustomerRepository(ShipadvisorContext ctx)
        {
            _ctx = ctx;
            _firebase = new FirebaseManager();
        }
        

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _ctx.Customers;
        }

        public async Task CreateCustomer(Customer customer, string password)
        { 
            var userRecord = await _firebase.CreateFirebaseUser(customer.Email, password);
            customer.UId = userRecord.Uid;
            var customerSaved = _ctx.Customers.Add(customer).Entity;
            _ctx.SaveChanges();
        }
        
    }
}