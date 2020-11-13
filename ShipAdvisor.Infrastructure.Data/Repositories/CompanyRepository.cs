using System.Linq;
using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Infrastructure.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ShipadvisorContext _ctx;

        public CompanyRepository(ShipadvisorContext ctx)
        {
            _ctx = ctx;
        }

        public Company CreateCompany(Company company)
        {
            var companySaved = _ctx.Companies.Add(company).Entity;
            _ctx.SaveChanges();
            return companySaved;
        }

        public Company ReadCompanyById(string id)
        {
            return _ctx.Companies.FirstOrDefault(c => c.uId == id);
        }
    }
}