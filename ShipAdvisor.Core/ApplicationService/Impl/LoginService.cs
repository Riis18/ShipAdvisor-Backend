using ShipAdvisor.Core.DomainService;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService.Impl
{
    public class LoginService : ILoginService
    {
        private readonly ICustomerRepository _customerRepo;

        public LoginService(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public object UserLoggedIn(string uid)
        {
            return null;
        }
    }
}