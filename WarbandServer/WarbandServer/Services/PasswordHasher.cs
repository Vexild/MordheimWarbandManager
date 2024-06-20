using Microsoft.EntityFrameworkCore;
using Bcrypt = BCrypt.Net.BCrypt;
namespace WarbandServer.Services
{
    public class PasswordHasher : DbContext
    {
        public static string HashPassword(string password)
        {
            password = Bcrypt.HashPassword(password);
            return password;
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return Bcrypt.Verify(password, passwordHash);
        }
    }
}
