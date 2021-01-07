using System;
using System.Collections.Generic;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data
{
    public class DBInitializer
    {
        public static void SeedDb(ShipadvisorContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            
            
            var customer1 = ctx.Customers.Add(new Customer()
            {
                UId = "IjbfpNeV2CakIphFiLdTMhBoQJb2",
                FirstName = "Jesper",
                LastName = "Riis",
                Email = "testcustomer@hotmail.com",
                PhoneNumber = "27282728",
                Address1 = "BingoStreet 21",
                Address2 = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
                Role = "Customer"
            }).Entity;
            
            var customer2 = ctx.Customers.Add(new Customer()
            {
                UId = "43usFVlVxAbhsjgc1cN7IbAk9j43",
                FirstName = "Tina",
                LastName = "Riis",
                Email = "testcustomer2@hotmail.com",
                PhoneNumber = "27282728",
                Address1 = "BingoStreet 21",
                Address2 = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
                Role = "Customer"
            }).Entity;
            
            var companyCustomer = ctx.Customers.Add(new Customer()
            {
                UId = "Evqtbyo4PnbwuFpi4bgYyi0hDxK2",
                CompanyName = "Shipping Firma :)",
                Email = "testcompany@hotmail.com",
                PhoneNumber = "58468431",
                Address1 = "BingoStreet 21",
                Address2 = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
                Role = "CompanyCustomer"
            }).Entity;
            
            var packageList = new List<PackageList>();
            var package = new PackageList {Id = 1, Item = "Stole", Quantity = 2, ShipmentOrderId = 1};
            packageList.Add(package);

            var order1 = ctx.ShipmentOrders.Add(new ShipmentOrder()
            {
                Id = 1,
                BiddingStatus = "Open",
                OrderStatus = "Pending",
                Customer = customer1,
                Company = null,
                PackageLists = packageList,
                OrderCreated = DateTime.Now,
                ShipmentType = "Container",
                ShipmentSize = "20 fods",
                Quantity = 1,
                PickUpAddress = "Bongolostreet 2",
                PickUpAddress2 = "2, sal",
                PickUpCity = "Esbjerg",
                PickUpCountry = "Danmark",
                PickUpZipCode = 6715,
                PickUpTime = DateTime.Now,
                DeliveryAddress = "BambosselStreet 233",
                DeliveryAddress2 = "4, sal",
                DeliveryCountry = "United States of America",
                DeliveryCity = "San Fransisco",
                DeliveryZipCode = 27372,
                DeliveryTime = DateTime.Now
            }).Entity;
            
            var order2 = ctx.ShipmentOrders.Add(new ShipmentOrder()
            {
                Id = 2,
                BiddingStatus = "Closed",
                OrderStatus = "Pending",
                Customer = customer2,
                Company = null,
                PackageLists = packageList,
                OrderCreated = DateTime.Now,
                ShipmentType = "Container",
                ShipmentSize = "20 fods",
                Quantity = 1,
                PickUpAddress = "Bongolostreet 2",
                PickUpAddress2 = "2, sal",
                PickUpCity = "Esbjerg",
                PickUpZipCode = 6715,
                PickUpTime = DateTime.Now,
                DeliveryAddress = "BambosselStreet 233",
                DeliveryAddress2 = "4, sal",
                DeliveryCountry = "United States of America",
                DeliveryCity = "San Fransisco",
                DeliveryZipCode = 27372,
                DeliveryTime = DateTime.Now
            }).Entity;
            
            var order3 = ctx.ShipmentOrders.Add(new ShipmentOrder()
            {
                Id = 3,
                BiddingStatus = "Open",
                OrderStatus = "Pending",
                Customer = customer1,
                Company = null,
                PackageLists = packageList,
                OrderCreated = DateTime.Now,
                ShipmentType = "Container",
                ShipmentSize = "20 fods",
                Quantity = 1,
                PickUpAddress = "Bongolostreet 2",
                PickUpAddress2 = "2, sal",
                PickUpCity = "Esbjerg",
                PickUpCountry = "Danmark",
                PickUpZipCode = 6715,
                PickUpTime = DateTime.Now,
                DeliveryAddress = "BambosselStreet 233",
                DeliveryAddress2 = "4, sal",
                DeliveryCountry = "United States of America",
                DeliveryCity = "San Fransisco",
                DeliveryZipCode = 27372,
                DeliveryTime = DateTime.Now
            }).Entity;

            ctx.SaveChanges();
        }
    }
}