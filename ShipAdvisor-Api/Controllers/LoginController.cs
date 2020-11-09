using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShipAdvisor.Core.ApplicationService;
using ShipAdvisor.Core.Entity;

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

        [HttpPost("addcustomer")]
        public ActionResult CreateCustomer([FromBody] Customer customer)
        {
            try
            {
                return Ok(_customerService.CreateCustomer(customer));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}