using System.Collections.Generic;
using System.Linq;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService.Impl
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }
        
        public List<Customer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers().ToList();
        }
    }
}