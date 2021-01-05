using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface IShipmentRepository
    {
        ShipmentOrder CreateOrder(ShipmentOrder order);
        IEnumerable<ShipmentOrder> GetAllCustomersOrder(string id);

        IEnumerable<ShipmentOrder> GetAllCustomerQueries();
        
        ShipmentOrder GetOrderQuerieById(int id);

        ShipmentOrder GetOrderById(int id);

        Bid CreateBid(Bid bid);

        IEnumerable<Bid> GetAllBidsForQuery(int id);
    }
}