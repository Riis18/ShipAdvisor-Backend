using System.Collections.Generic;
using System.Threading.Tasks;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICustomerRepository
    {
        //Get list of all customers
        IEnumerable<Customer> GetAllCustomers();

        Customer ReadCustomerByUid(string id);

        Task CreateCustomer(Customer customer, string password);
        
        IEnumerable<Bid> GetBidsByOrderId(int id);
        
        void UpdateCustShipment(ShipmentOrder order, List<Bid> bids, Bid bid);
    }
}