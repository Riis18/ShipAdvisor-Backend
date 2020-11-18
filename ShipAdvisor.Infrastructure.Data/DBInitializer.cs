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

            ctx.SaveChanges();
        }
    }
}