using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService.Impl
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepo)
        {
            _companyRepository = companyRepo;
        }

        public Company CreateCompany(Company company)
        {
            return _companyRepository.CreateCompany(company);
        }

        public Company ReadCompanyById(string id)
        {
            return _companyRepository.ReadCompanyById(id);
        }
    }
}