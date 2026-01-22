using Xunit;
using UserManagementApp.Core.Services;
using UserManagementApp.Core.Logging;

namespace UserManagementApp.Tests
{
    public class AuthenticationTests
    {
        [Fact]
        
        public void User_Should_Register_And_Login_Successfully()
        {
            LoggerConfig.Configure();
            var service = new UserService();

            service.Register("akhila", "Password123", "a@mail.com");

            bool result = service.Authenticate("akhila", "Password123");

            Assert.True(result);
        }
    }
}
