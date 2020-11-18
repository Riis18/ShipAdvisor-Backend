using ShipAdvisor.Core.Entity;

namespace ShipAdvisor_Api.Dtos
{
    public class UserDto
    {
        public Customer Customer { get; set; }

        public string Password { get; set; }
    }
}