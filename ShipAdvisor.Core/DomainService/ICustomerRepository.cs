using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICustomerRepository
    {
        //Get list of all customers
        IEnumerable<Customer> GetAllCustomers();

        Customer CreateCustomer(Customer customer);
    }
}