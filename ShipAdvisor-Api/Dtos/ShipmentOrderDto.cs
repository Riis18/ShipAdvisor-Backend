using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor_Api.Dtos
{
    public class ShipmentOrderDto
    {
        public Customer Customer { get; set; }
        
        public List<Bid> Bids { get; set; }
        
        public Bid Bid { get; set; }
        
        public ShipmentOrder Shipment { get; set; }
        
        public List<PackageList> PackageLists { get; set; }
    }
}