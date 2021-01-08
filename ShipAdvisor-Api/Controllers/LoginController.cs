using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// Initiates the LoginController
        /// </summary>
        /// <param name="customerService">Contains the service logic</param>
        public LoginController(ICustomerService customerService)
        {
            _customerService = customerService; ;
        }

        /// <summary>
        /// Uses the Dto to map information from the request body
        /// and after that is sends it to the ICustomerService
        /// </summary>
        /// <param name="customerData">Contains the data for customer entity and password</param>
        /// <returns>Ok code if succesful else a badrequest code with message</returns>
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
        
        /// <summary>
        /// calls upon the ICustomerService to retrieve a user by id
        /// </summary>
        /// <param name="id">id of user</param>
        /// <returns>the customer entity</returns>
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
        }
        
    }
}