using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface IShipmentRepository
    {
        /// <summary>
        /// Creates a order in the database
        /// </summary>
        /// <param name="order">the order to be created</param>
        /// <returns>the created order</returns>
        ShipmentOrder CreateOrder(ShipmentOrder order);
        
        /// <summary>
        /// Returns a IEnumerable of all the orders belonging to the customer
        /// </summary>
        /// <param name="id">id of customer</param>
        /// <returns>List of customer orders</returns>
        IEnumerable<ShipmentOrder> GetAllCustomersOrder(string id);

        /// <summary>
        /// Returns a IEnumerable of all the orders belonging to the customer
        /// </summary>
        /// <returns>List of customer orders</returns>
        IEnumerable<ShipmentOrder> GetAllCustomerQueries();
        
        /// <summary>
        /// Gets the order by id
        /// </summary>
        /// <param name="id">id of the order</param>
        /// <returns>the selected order</returns>
        ShipmentOrder GetOrderQuerieById(int id);

        /// <summary>
        /// Gets the order by id
        /// </summary>
        /// <param name="id">id of the order</param>
        /// <returns>the selected order</return
        ShipmentOrder GetOrderById(int id);

        /// <summary>
        /// creates the bid in the database
        /// </summary>
        /// <param name="bid">bid to be created</param>
        /// <returns>the created bid</returns>
        Bid CreateBid(Bid bid);
        
        /// <summary>
        /// Returns a IEnumerable of all bids belonging to the order
        /// </summary>
        /// <param name="id">id of order</param>
        /// <returns>all bids for the order</returns>
        IEnumerable<Bid> GetAllBidsForQuery(int id);
    }
}