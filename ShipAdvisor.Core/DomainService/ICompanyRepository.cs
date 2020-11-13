using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.DomainService
{
    public interface ICompanyRepository
    {
        Company CreateCompany(Company company);

        Company ReadCompanyById(string id);
    }
}