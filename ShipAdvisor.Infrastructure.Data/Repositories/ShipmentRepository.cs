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
        public ShipmentOrder CreateOrder(ShipmentOrder order, List<PackageList> packageLists)
        {
            order.OrderCreated = DateTime.Now;
            order.OrderStatus = "Open";
            order.BiddingStatus = "Open";
            order.PackageLists = packageLists;
            _ctx.ShipmentOrders.Attach(order).State = EntityState.Added;
            /*foreach (var package in packageLists)
            {
                _ctx.Entry(package).State = EntityState.Added;
            }*/

            _ctx.SaveChanges();

            return order;
        }

        public IEnumerable<ShipmentOrder> GetAllCustomersOrder(string id)
        {
            return _ctx.ShipmentOrders
                .Include(p => p.PackageLists)
                .Where(s => s.Customers.All(c => c.UId == id));
        }
    }
}