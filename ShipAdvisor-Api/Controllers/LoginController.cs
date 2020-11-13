using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShipAdvisor.Core.ApplicationService;
using ShipAdvisor.Core.Entity;
using ShipAdvisor_Api.Dtos;

namespace ShipAdvisor_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public LoginController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("createCustomer")]
        public async Task<ActionResult> CreateCustomer([FromBody] CustomerDto customerData)
        {
            try
            {
                var password = customerData.Password;
                Customer customer = customerData.Customer;
                
                await _customerService.CreateCustomer(customer, password);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}