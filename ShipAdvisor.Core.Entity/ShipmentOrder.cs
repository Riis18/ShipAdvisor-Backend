using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ShipAdvisor.Core.Entity
{
    public class ShipmentOrder
    {
        public int Id { get; set; }
        
        public string BiddingStatus { get; set; }
        
        public string OrderStatus { get; set; }

        public List<Customer> Customers { get; set; }
        
        public List<PackageList> PackageLists { get; set; }
        
        public DateTime OrderCreated { get; set; }
        
        public string ShipmentType { get; set; }
        
        public int Quantity { get; set; }
        
        public string PickUpAddress { get; set; } 
        
        public string PickUpAddress2 { get; set; }
        
        public string PickUpCountry { get; set; }
        
        public string PickUpCity { get; set; }
        
        public int PickUpZipCode { get; set; }
        
        public DateTime PickUpTime { get; set; }
        
        public string DeliveryAddress { get; set; } 
        
        public string DeliveryAddress2 { get; set; }
        
        public string DeliveryCountry { get; set; }
        
        public string DeliveryCity { get; set; }
        
        public int DeliveryZipCode { get; set; }
        
        public DateTime DeliveryTime { get; set; }
    }
}