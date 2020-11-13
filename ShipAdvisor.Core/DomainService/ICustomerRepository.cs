using System.Collections.Generic;
using System.Threading.Tasks;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICustomerRepository
    {
        //Get list of all customers
        IEnumerable<Customer> GetAllCustomers();

        Task CreateCustomer(Customer customer, string password);
    }
}