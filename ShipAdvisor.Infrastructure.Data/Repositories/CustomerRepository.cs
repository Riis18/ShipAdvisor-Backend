using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;
using ShipAdvisor.Infrastructure.Data.Managers;

namespace ShipAdvisor.Infrastructure.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly ShipadvisorContext _ctx;
        private FirebaseManager _firebase;

        public CustomerRepository(ShipadvisorContext ctx)
        {
            _ctx = ctx;
            _firebase = new FirebaseManager();
        }
        

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _ctx.Customers;
        }
        
        public Customer ReadCustomerByUid(string id)
        {
            return _ctx.Customers.FirstOrDefault(c => c.UId == id);
        }

        public async Task CreateCustomer(Customer customer, string password)
        { 
            var userRecord = await _firebase.CreateFirebaseUser(customer.Email, password);
            customer.UId = userRecord.Uid;
            customer.Role = "Customer";
            var customerSaved = _ctx.Customers.Add(customer).Entity;
            _ctx.SaveChanges();
        }

        public IEnumerable<Bid> GetBidsByOrderId(int id)
        {
            return _ctx.Bids
                .Include(c => c.Company)
                .Where(s => s.ShipmentOrder.Id == id);
        }

        public void UpdateCustShipment(ShipmentOrder order, List<Bid> bids, Bid bid)
        {

            bids.ForEach(b =>
            {
                if (b.Id == bid.Id) return;
                Console.WriteLine(b.Id + "  " + bid.Id);
                _ctx.Bids.Remove(b);
            });
            Console.WriteLine("not yet");
            Console.WriteLine("Yes");
            var shipmentOrder = _ctx.ShipmentOrders.FirstOrDefault(s => s.Id == order.Id);
            shipmentOrder.BiddingStatus = "Closed";
            shipmentOrder.OrderStatus = "Active";
            _ctx.ShipmentOrders.Update(shipmentOrder);
            _ctx.SaveChanges();

        }
    }
}