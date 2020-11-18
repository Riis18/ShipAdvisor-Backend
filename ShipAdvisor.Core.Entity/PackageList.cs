namespace ShipAdvisor.Core.Entity
{
    public class PackageList
    {
        public int Id { get; set; }
        
        public int ShipmentOrderId { get; set; }
        
        public string Item { get; set; }
        
        public int Quantity { get; set; }
        
        public ShipmentOrder ShipmentOrder { get; set; }
    }
}