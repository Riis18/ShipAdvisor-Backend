using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICustomerRepository
    {
        //Create Customer Data
        Customer Create(Customer customer);

        //Read customer by id
        Customer ReadById(int id);

        //Get list of all customers
        List<Customer> GetAllCustomers();

        //Update customer
        Customer Update(Customer customer);

        //Delete a customer by id
        Customer Delete(int id);
    }
}