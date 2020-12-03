using System.Collections.Generic;

namespace ShipAdvisor.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string UId { get; set; }
        
        public List<ShipmentOrder> ShipmentOrders { get; set; }

        public string Role { get; set; }
        
        public string CompanyName { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        
        public string Address1 { get; set; }
        
        public string Address2 { get; set; }
        
        public string City { get; set; }
        
        public int ZipCode { get; set; }
        
        public string Country { get; set; }
        
    }
}