using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface IShipmentRepository
    {
        ShipmentOrder CreateOrder(ShipmentOrder order, List<PackageList> packageLists);
        IEnumerable<ShipmentOrder> GetAllCustomersOrder(string id);
    }
}