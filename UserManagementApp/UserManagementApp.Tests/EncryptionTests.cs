using Xunit;
using UserManagementApp.Core.Security;

namespace UserManagementApp.Tests
{
    public class EncryptionTests
    {
        [Fact]
        public void Encrypt_And_Decrypt_Should_Return_Same_Data()
        {
            string original = "SensitiveData";

            string encrypted = AesEncryption.Encrypt(original);
            string decrypted = AesEncryption.Decrypt(encrypted);

            Assert.Equal(original, decrypted);
        }
    }
}
