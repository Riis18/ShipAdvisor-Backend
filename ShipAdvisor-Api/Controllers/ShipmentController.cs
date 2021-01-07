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
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentService _shipmentService;
        
        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }
        
        
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