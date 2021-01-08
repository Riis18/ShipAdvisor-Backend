using System.Collections.Generic;
using System.Threading.Tasks;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// gets the selected customer
        /// </summary>
        /// <param name="id">id of customer</param>
        /// <returns>the customer</returns>
        Customer ReadCustomerByUid(string id);

        /// <summary>
        /// Creates the customer in the database and in firebase
        /// </summary>
        /// <param name="customer">Customer to be inserted in database</param>
        /// <param name="password">password to be used for firebase user creation</param>
        /// <returns></returns>
        Task CreateCustomer(Customer customer, string password);
        
        /// <summary>
        /// Gets a list of all the bids belonging to the order
        /// </summary>
        /// <param name="id">id of order</param>
        /// <returns>List of bids</returns>
        IEnumerable<Bid> GetBidsByOrderId(int id);
        
        /// <summary>
        /// Updates the order and removes all but the selected bid from it
        /// </summary>
        /// <param name="order">Order to be updated</param>
        /// <param name="bids">Lists of bids</param>
        /// <param name="bid">The selected bid</param>
        void UpdateCustShipment(ShipmentOrder order, List<Bid> bids, Bid bid);
    }
}