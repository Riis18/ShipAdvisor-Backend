namespace ShipAdvisor.Core.Entity
{
    public class Company
    {
        public int Id { get; set; }
        
        public string uId { get; set; }
        
        public string CompanyName { get; set; }
        
        public string CompanyAddress { get; set; }
        
        public string CompanyAddress2 { get; set; }
        
        public string CompanyCity { get; set; }
        
        public int CompanyZipCode { get; set; }
        
        public string CompanyCountry { get; set; }
        
        public string CompanyEmail { get; set; }
        
        public string Phone { get; set; }
        
        public string CvrNumber { get; set; }
    }
}