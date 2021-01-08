using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Task CreateCustomer(Customer customer, string password)
        {
             return _customerRepo.CreateCustomer(customer, password);
        }

        public Customer GetCustomerByUid(string id)
        {
            return _customerRepo.ReadCustomerByUid(id);
        }

        public List<Bid> GetBidsByOrderId(int id)
        {
            return _customerRepo.GetBidsByOrderId(id).ToList();
        }

        public void UpdateCustShipment(ShipmentOrder order, List<Bid> bids, Bid bid)
        {
            _customerRepo.UpdateCustShipment(order, bids, bid);
        }
    }
}