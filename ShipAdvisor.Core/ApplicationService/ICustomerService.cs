using System.Collections.Generic;
using System.Threading.Tasks;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        
        Task CreateCustomer(Customer customer, string password);
    }
}