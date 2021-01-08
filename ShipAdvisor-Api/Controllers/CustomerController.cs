using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShipAdvisor.Core.ApplicationService;
using ShipAdvisor.Core.Entity;
using ShipAdvisor_Api.Dtos;

namespace ShipAdvisor_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        /// <summary>
        /// Initiates the CustomerController
        /// </summary>
        /// <param name="customerService">Contains service logic</param>
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// gets the bids for a order and returns it
        /// </summary>
        /// <param name="id">id of order</param>
        /// <returns>All bids for selected order</returns>
        [HttpGet("bid/{id}")]
        public ActionResult<IEnumerable<Bid>> GetBidsByOrderId(int id)
        {
            try
            {
                return _customerService.GetBidsByOrderId(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// Uses the Dto class to map information from the request body
        /// and sends it to the ICustomerService
        /// </summary>
        /// <param name="shipDto">Contains data on entities</param>
        /// <returns>An error if there is one</returns>
        [HttpPut("updateShipment")]
        public ActionResult<ShipmentOrder> UpdateCustShipment([FromBody] ShipmentOrderDto shipDto)
        {
            try
            {
                var order = shipDto.Shipment;
                var bids = shipDto.Bids;
                var bid = shipDto.Bid;
                _customerService.UpdateCustShipment(order, bids, bid);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }
        
    }
}