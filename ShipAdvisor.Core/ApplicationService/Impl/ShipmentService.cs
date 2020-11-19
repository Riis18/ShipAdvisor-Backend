using System.Collections.Generic;
using System.Linq;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService.Impl
{
    public class ShipmentService : IShipmentService
    {
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentService(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }
        public ShipmentOrder CreateOrder(ShipmentOrder order)
        {
            return _shipmentRepository.CreateOrder(order);
        }

        public List<ShipmentOrder> GetAllCustomersOrder(string id)
        {
            return _shipmentRepository.GetAllCustomersOrder(id).ToList();
        }
    }
}