using System;
using System.Collections;
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

        public List<ShipmentOrder> GetAllCustomerQueries(string id)
        {
            var queriesNotBidOn = new List<ShipmentOrder>();
            _shipmentRepository.GetAllCustomerQueries().ToList().ForEach(query =>
            {
                var bidsForQuery = _shipmentRepository.GetAllBidsForQuery(query.Id).ToList();
                if (bidsForQuery.Count == 0)
                {
                    queriesNotBidOn.Add(query);
                }
                else
                {
                    bidsForQuery.ForEach(bid =>
                    {
                        if (bid.Company == null)
                        {
                            queriesNotBidOn.Add(query);
                        }
                    });
                }
            });
            
            return queriesNotBidOn;
        }

        public ShipmentOrder GetOrderQuerieById(int id)
        {
            return _shipmentRepository.GetOrderQuerieById(id);
        }

        public ShipmentOrder GetOrderById(int id)
        {
            return _shipmentRepository.GetOrderById(id);
        }

        public Bid CreateBid(Bid bid)
        {
            return _shipmentRepository.CreateBid(bid);
        }
    }
}