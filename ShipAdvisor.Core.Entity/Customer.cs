namespace ShipAdvisor.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        
        public string StreetName { get; set; }
        
        public string ApartmentNumber { get; set; }
        
        public string City { get; set; }
        
        public int ZipCode { get; set; }
        
        public string Country { get; set; }
    }
}