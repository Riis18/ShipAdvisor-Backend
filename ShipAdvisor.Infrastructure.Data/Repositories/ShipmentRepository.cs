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
            order.OrderStatus = "Pending";
            order.BiddingStatus = "Open";
            order.BidCount = 0;
            _ctx.ShipmentOrders.Attach(order).State = EntityState.Added;

            _ctx.SaveChanges();

            return order;
        }

        public IEnumerable<ShipmentOrder> GetAllCustomersOrder(string id)
        {
            return _ctx.ShipmentOrders
                .Include(p => p.PackageLists)
                .Where(s => s.Customer.UId == id)
                .Where(s => s.OrderStatus == "Pending")
                .OrderByDescending(s => s.OrderCreated);
        }

        public IEnumerable<ShipmentOrder> GetAllCustomerQueries()
        {
            return _ctx.ShipmentOrders
                .Include(p => p.PackageLists)
                .Include(c => c.Bids)
                .Where(s => s.BiddingStatus == "Open")
                .OrderByDescending(s => s.OrderCreated);
        }

        public ShipmentOrder GetOrderQuerieById(int id)
        {
            return _ctx.ShipmentOrders
                .Include(p => p.PackageLists)
                .FirstOrDefault(s => s.Id == id);
        }

        public ShipmentOrder GetOrderById(int id)
        {
            return _ctx.ShipmentOrders
                .Include(p => p.PackageLists)
                .Include(b => b.Bids)
                .Include( c => c.Company)
                .FirstOrDefault(s => s.Id == id);
        }

        public Bid CreateBid(Bid bid)
        {
            _ctx.Bids.Attach(bid).State = EntityState.Added;
            var order = _ctx.ShipmentOrders.FirstOrDefault(s => s.Id == bid.ShipmentOrder.Id);
            if (order != null)
            {
                order.BidCount++;
                var dbEntry = _ctx.Entry(order);
                dbEntry.Property("BidCount").IsModified = true;
            }
            
            _ctx.SaveChanges();

            return bid;
        }

        public IEnumerable<Bid> GetAllBidsForQuery(int id)
        {
            return _ctx.Bids
                .Include(c => c.Company)
                .Include( s => s.ShipmentOrder)
                .Where( b => b.ShipmentOrder.Id == id);
        }
    }
}