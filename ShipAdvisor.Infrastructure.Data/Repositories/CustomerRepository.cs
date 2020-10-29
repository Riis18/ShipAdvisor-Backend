using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        public Customer Create(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Customer ReadById(int id)
        {
            throw new System.NotImplementedException();
            
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customer1 = new Customer();
            var test = new List<Customer>();
            customer1.id = 1;
            customer1.FirstName = "Jesper";
            customer1.LastName = "Riis";
            customer1.Email = "Riisjesper@hotmail.com";
            customer1.password = "wuptidupti";
            test.Add(customer1);
            return test;
        }

        public Customer Update(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}