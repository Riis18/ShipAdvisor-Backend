using ShipAdvisor.Core.Entity;

namespace ShipAdvisor_Api.Dtos
{
    public class CustomerDto
    {
        public Customer Customer { get; set; }
        
        public string Password { get; set; }
    }
}