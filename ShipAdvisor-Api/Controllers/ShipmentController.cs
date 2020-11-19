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
        public ActionResult<ShipmentOrder> CreateOrder([FromBody] ShipmentOrderDto orderDto)
        {
            try
            {
                ShipmentOrder order = orderDto.ShipmentOrder;
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
    }
}