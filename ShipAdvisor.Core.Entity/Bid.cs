using System;
using System.Collections.Generic;

namespace ShipAdvisor.Core.Entity
{
    public class Bid
    {
        public int Id { get; set; }
        
        public Customer Company { get; set; }
        
        public ShipmentOrder ShipmentOrder { get; set; }
        
        public DateTime PickUpDate { get; set; }
        
        public DateTime DeliveryDate { get; set; }
        
        public string TransportMethod { get; set; }
        
        public int TransportPrice { get; set; }
        
        public int CustomPrice { get; set; }
        
        public int TotalPrice { get; set; }
        
        public List<BidInfo> BidInfos { get; set; }
    }
}