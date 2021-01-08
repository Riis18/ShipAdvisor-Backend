using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShipAdvisor.Core.ApplicationService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentService _shipmentService;
        
        /// <summary>
        /// Initiates the ShipmentController
        /// </summary>
        /// <param name="shipmentService">Contains service logic</param>
        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }
        
        /// <summary>
        /// Maps the information from body to the ShipmentOrder entity
        /// </summary>
        /// <param name="orderDto">Contains the ShipmentOrder entity</param>
        /// <returns>the created shipment</returns>
        [HttpPost("createShipment")]
        public ActionResult<ShipmentOrder> CreateOrder([FromBody] ShipmentOrder orderDto)
        {
            try
            {
                ShipmentOrder order = orderDto;
                var shipment = _shipmentService.CreateOrder(order);

                return shipment;

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Calls upon the IShipmentInterface to retrieve all the orders
        /// that belongs to the customer
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>all the orders for the customer</returns>
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<ShipmentOrder>> GetAllCustomersOrder(string id)
        {
            try
            {
                return _shipmentService.GetAllCustomersOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// Calls upon IShipmentService to retrieve the order with
        /// the given id
        /// </summary>
        /// <param name="id">Id of order</param>
        /// <returns>the selected order</returns>
        [HttpGet("order/{id}")]
        public ActionResult<ShipmentOrder> GetOrderById(int id)
        {
            try
            {
                return _shipmentService.GetOrderById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// gets all the orders that are open for bid and returns them
        /// </summary>
        /// <param name="id">id of customer</param>
        /// <returns>All the orders that are open for bids</returns>
        [HttpGet("{id}/queries")]
        public ActionResult<IEnumerable<ShipmentOrder>> GetAllCustomerQueries(string id)
        {
            try
            {
                return _shipmentService.GetAllCustomerQueries(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// Retrieves the selected order by the given id
        /// </summary>
        /// <param name="id">id of order</param>
        /// <returns>get the selected order</returns>
        [HttpGet("queries/{id}")]
        public ActionResult<ShipmentOrder> GetOrderQuerieById(int id)
        {
            try
            {
                return _shipmentService.GetOrderQuerieById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// Sends the bid to IShipmentService
        /// </summary>
        /// <param name="bid">Contains data for the bid entity</param>
        /// <returns>the created bid</returns>
        [HttpPost("createBid")]
        public ActionResult<Bid> CreateBid([FromBody] Bid bid)
        {
            try
            {
                return _shipmentService.CreateBid(bid);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}