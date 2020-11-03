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
                FirstName = "Jesper",
                LastName = "Riis",
                Email = "Riisjesper@hotmail.com",
                PhoneNumber = "27282728",
                StreetName = "BingoStreet 21",
                ApartmentNumber = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
            }).Entity;
            
            var customer2 = ctx.Customers.Add(new Customer()
            {
                FirstName = "Tina",
                LastName = "Jønson",
                Email = "JønsonTina@hotmail.com",
                PhoneNumber = "58468431",
                StreetName = "BingoStreet 21",
                ApartmentNumber = "2. sal",
                City = "Esbjerg",
                Country = "Denmark",
                ZipCode = 6700,
            }).Entity;

            ctx.SaveChanges();
        }
    }
}