using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor_Api.Dtos
{
    public class ShipmentOrderDto
    {
        public ShipmentOrder ShipmentOrder { get; set; }
        
        public List<PackageList> PackageLists { get; set; }
    }
}