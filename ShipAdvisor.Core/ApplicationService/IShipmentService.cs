using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface IShipmentService
    {
        /// <summary>
        /// Creates a order in the database
        /// </summary>
        /// <param name="order">the order to be created</param>
        /// <returns>the created order</returns>
        ShipmentOrder CreateOrder(ShipmentOrder order);
        
        /// <summary>
        /// Returns a list of all the orders belonging to the customer
        /// </summary>
        /// <param name="id">id of customer</param>
        /// <returns>List of customer orders</returns>
        List<ShipmentOrder> GetAllCustomersOrder(string id);

        /// <summary>
        /// Returns a list of all the orders belonging to the customer
        /// </summary>
        /// <param name="id">id of customer</param>
        /// <returns>List of customer orders</returns>
        List<ShipmentOrder> GetAllCustomerQueries(string id);

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
        /// <returns>the selected order</returns>
        ShipmentOrder GetOrderById(int id);

        /// <summary>
        /// creates the bid in the database
        /// </summary>
        /// <param name="bid">bid to be created</param>
        /// <returns>the created bid</returns>
        Bid CreateBid(Bid bid);
        
    }
}