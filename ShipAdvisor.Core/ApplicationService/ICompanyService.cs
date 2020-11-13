using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface ICompanyService
    {
        Company CreateCompany(Company company);

        Company ReadCompanyById(string id);
    }
}