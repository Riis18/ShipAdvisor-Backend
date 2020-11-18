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
        private readonly ILoginService _loginService;

        public LoginController(ICustomerService customerService,
            ILoginService loginService)
        {
            _customerService = customerService;
            _loginService = loginService;
        }

        [HttpPost("createCustomer")]
        public async Task<ActionResult> CreateCustomer([FromBody] UserDto customerData)
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
        
        [HttpGet("{id}")]
        public ActionResult<Customer> GetUserSignedIn(string id)
        {
            try
            {
                var userDto = _customerService.GetCustomerByUid(id);
                return userDto;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            ;
        }
        
    }
}