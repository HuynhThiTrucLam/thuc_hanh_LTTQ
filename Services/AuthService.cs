using System.Security.Cryptography;
using System.Text;
using WinFormsCore.Models; // Thay thế bằng namespace thực tế cho lớp Account
using Microsoft.EntityFrameworkCore;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Services // Thay thế bằng namespace của dự án
{
    public class AuthService
    {
        private readonly ShopContext _context;

        public AuthService(ShopContext context)
        {
            _context = context;
        }

        public Account Login(string username, string password)
        {

            var passwordHash = HashPassword(password);
            
            var account = _context.Accounts.FirstOrDefault(a => a.Username == username && a.Pword == password);
            return account;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
