using System.Security.Cryptography;
using System.Text;

namespace UserManagementApp.Core.Security
{
    public static class AesEncryption
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456");
        private static readonly byte[] IV  = Encoding.UTF8.GetBytes("6543210987654321");

        public static string Encrypt(string data)
        {
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            var encryptor = aes.CreateEncryptor();
            var bytes = Encoding.UTF8.GetBytes(data);
            var encrypted = encryptor.TransformFinalBlock(bytes, 0, bytes.Length);

            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string encryptedData)
        {
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            var decryptor = aes.CreateDecryptor();
            var bytes = Convert.FromBase64String(encryptedData);
            var decrypted = decryptor.TransformFinalBlock(bytes, 0, bytes.Length);

            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
