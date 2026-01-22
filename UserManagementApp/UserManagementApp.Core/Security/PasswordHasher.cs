using System.Security.Cryptography;
using System.Text;

namespace UserManagementApp.Core.Security
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public static bool Verify(string password, string hashedPassword)
        {
            return HashPassword(password) == hashedPassword;
        }
    }
}
