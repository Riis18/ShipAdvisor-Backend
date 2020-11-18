using System;
using System.Threading.Tasks;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace ShipAdvisor.Infrastructure.Data.Managers
{
    public class FirebaseManager
    {
        public async Task<UserRecord> CreateFirebaseUser(string email, string password)
        {
            UserRecordArgs args = new UserRecordArgs()
            {
                Email = email,
                EmailVerified = false,
                PhoneNumber = null,
                Password = password,
                DisplayName = "",
                PhotoUrl = null,
                Disabled = false,
            };
            UserRecord userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(args);

            return userRecord;
        }
    }
}