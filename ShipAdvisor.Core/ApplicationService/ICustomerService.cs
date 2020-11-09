using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        
        Customer CreateCustomer(Customer customer);
    }
}