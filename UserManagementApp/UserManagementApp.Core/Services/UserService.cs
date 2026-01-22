using UserManagementApp.Core.Models;
using UserManagementApp.Core.Security;
using Serilog;
using System.Linq;

namespace UserManagementApp.Core.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();

        public void Register(string username, string password, string email)
        {
            try
            {
                var user = new User
                {
                    Username = username,
                    HashedPassword = PasswordHasher.HashPassword(password),
                    EncryptedEmail = AesEncryption.Encrypt(email)
                };

                _users.Add(user);
                Log.Information("User registered successfully: {Username}", username);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error during user registration");
                throw new ApplicationException("Registration failed");
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                var user = _users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    Log.Warning("Login failed. User not found: {Username}", username);
                    return false;
                }

                bool isValid = PasswordHasher.Verify(password, user.HashedPassword);

                if (isValid)
                    Log.Information("User authenticated successfully: {Username}", username);
                else
                    Log.Warning("Invalid password attempt for user: {Username}", username);

                return isValid;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Authentication error");
                throw new ApplicationException("Login error");
            }
        }
    }
}
