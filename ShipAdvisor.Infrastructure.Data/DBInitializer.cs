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
                Address = "BingoStreet 21",
                Address2 = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
            }).Entity;
            
            var customer2 = ctx.Customers.Add(new Customer()
            {
                FirstName = "Tina",
                LastName = "Jønson",
                Email = "testcustomer2@hotmail.com",
                PhoneNumber = "58468431",
                Address = "BingoStreet 21",
                Address2 = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
            }).Entity;

            var company1 = ctx.Companies.Add(new Company()
            {
                uId = "",
                CompanyName = "Test Company",
                CompanyAddress = "Test Address 123",
                CompanyAddress2 = "2.sal",
                CompanyCity = "Esbjerg",
                CompanyCountry = "Denmark",
                CompanyEmail = "testcompany@hotmail.com",
                CompanyZipCode = 6715,
                CvrNumber = "564846546132",
                Phone = "85486486"
            }).Entity;
            
            var company2 = ctx.Companies.Add(new Company()
            {
                uId = "",
                CompanyName = "ShipAdvisor",
                CompanyAddress = "Vesterhavsgade 55",
                CompanyAddress2 = "1.sal",
                CompanyCity = "Esbjerg",
                CompanyCountry = "Denmark",
                CompanyEmail = "testcompany2@hotmail.com",
                CompanyZipCode = 6715,
                CvrNumber = "894621782",
                Phone = "98451322"
            }).Entity;

            ctx.SaveChanges();
        }
    }
}