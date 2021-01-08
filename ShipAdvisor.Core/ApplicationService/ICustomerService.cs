using System.Collections.Generic;
using System.Threading.Tasks;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface ICustomerService
    {
        /// <summary>
        /// Creates user in database
        /// </summary>
        /// <param name="customer">Customer to be inserted in database</param>
        /// <param name="password">password to be used for firebase user creation</param>
        /// <returns> created customer</returns>
        Task CreateCustomer(Customer customer, string password);

        /// <summary>
        /// gets a user from the database
        /// </summary>
        /// <param name="id">id of customer</param>
        /// <returns>the user</returns>
        Customer GetCustomerByUid(string id);
        
        /// <summary>
        /// Gets all bids that belong to the selected order
        /// </summary>
        /// <param name="id">id of order</param>
        /// <returns>Returns a list of bids</returns>
        List<Bid> GetBidsByOrderId(int id);

        /// <summary>
        /// Updates the order and removes all but the selected bid from it
        /// </summary>
        /// <param name="order">Order to be updated</param>
        /// <param name="bids">Lists of bids</param>
        /// <param name="bid">The selected bid</param>
        void UpdateCustShipment(ShipmentOrder order, List<Bid> bids, Bid bid);
    }
}