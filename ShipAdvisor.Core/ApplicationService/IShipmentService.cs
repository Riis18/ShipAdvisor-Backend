using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface IShipmentService
    {
        ShipmentOrder CreateOrder(ShipmentOrder order);
        List<ShipmentOrder> GetAllCustomersOrder(string id);
    }
}