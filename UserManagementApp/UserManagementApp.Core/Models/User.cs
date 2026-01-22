namespace UserManagementApp.Core.Models
{
    public class User
    {
        public required string Username { get; set; }
        public required string HashedPassword { get; set; }
        public required string EncryptedEmail { get; set; }
    }
}
