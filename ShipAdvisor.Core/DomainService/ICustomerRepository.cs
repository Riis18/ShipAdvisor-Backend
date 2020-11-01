using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICustomerRepository
    {
        //Create Customer Data
        Customer Create(Customer customer);

        //Get list of all customers
        IEnumerable<Customer> GetAllCustomers();
        
    }
}