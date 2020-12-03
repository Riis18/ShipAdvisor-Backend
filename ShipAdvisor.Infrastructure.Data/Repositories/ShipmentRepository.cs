using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly ShipadvisorContext _ctx;

        public ShipmentRepository(ShipadvisorContext ctx)
        {
            _ctx = ctx;
        }
        public ShipmentOrder CreateOrder(ShipmentOrder order)
        {
            order.OrderCreated = DateTime.Now;
            order.OrderStatus = "Open";
            order.BiddingStatus = "Open";
            _ctx.ShipmentOrders.Attach(order).State = EntityState.Added;

            _ctx.SaveChanges();

            return order;
        }

        public IEnumerable<ShipmentOrder> GetAllCustomersOrder(string id)
        {
            return _ctx.ShipmentOrders
                .Include(p => p.PackageLists)
                .Where(s => s.Customers.Any(c => c.UId == id))
                .OrderByDescending(s => s.OrderCreated);
        }
    }
}