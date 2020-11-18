using System;
using ShipAdvisor.Core.Entity;

namespace ShipAdvisor.Core.ApplicationService
{
    public interface ILoginService
    {
        public Object UserLoggedIn(string uid);
    }
}