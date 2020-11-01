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
                Address = "BongoStreet",
                Email = "Riisjesper@hotmail.com",
                PhoneNumber = "27282728",
                Password = "hej123"
            }).Entity;
            
            var customer2 = ctx.Customers.Add(new Customer()
            {
                FirstName = "Tina",
                LastName = "Jønson",
                Address = "BongoStreet",
                Email = "JønsonTina@hotmail.com",
                PhoneNumber = "58468431",
                Password = "hejmeddig123"
            }).Entity;

            ctx.SaveChanges();
        }
    }
}