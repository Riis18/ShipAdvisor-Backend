using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(_customerService.GetAllCustomers());
        }
        
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