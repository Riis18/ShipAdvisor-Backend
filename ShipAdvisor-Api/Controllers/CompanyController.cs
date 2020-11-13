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
    public class CompanyController : ControllerBase
    {

        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("addCompany")]
        public ActionResult CreateCompany([FromBody] Company company)
        {
            try
            {
                return Ok(_companyService.CreateCompany(company));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Company> GetCompanyById(string id)
        {
            try
            {
                return Ok(_companyService.ReadCompanyById(id));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}