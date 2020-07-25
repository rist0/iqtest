using IQTest.Core.Entities;
using System;
using System.Security.Cryptography;

namespace IQTest.Data.Helpers
{
    public static class HashHelper
    {
        public static User CreateDefaulAdminUserObject()
        {
            var salt = "6Zbl2vCPw3rO36YI3y1jjDKjkY005YXkU5jdjrn5uk52O0IsvJvA1Ad5FAg90UHnlJPxCap7kj1NtqHE0TbP7enigNciQNEjB0AHnDS3DB2wnj86TSDCRec706wtgBQF";

            using var hmac = new HMACSHA512(System.Text.Encoding.UTF8.GetBytes(salt));

            var passwordSalt = hmac.Key;
            var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("password"));

            return new User
            {
                Id = 1,
                Username = "admin",
                EmailAddress = "admin@iqtest.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
        }

        public static (byte[] Hash, byte[] Salt) CreatePasswordHash(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Value cannot be empty  or whitespace only.", nameof(password));
            }

            using var hmac = new HMACSHA512();

            var passwordSalt = hmac.Key;
            var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return (passwordHash, passwordSalt);
        }

        public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Value cannot be empty  or whitespace only.", nameof(password));
            }
            if (storedHash.Length != 64)
            {
                throw new ArgumentNullException("Invalid length of password hash (expected 64 bytes).", nameof(storedHash));
            }
            if (storedSalt.Length != 128)
            {
                throw new ArgumentNullException("Invalid length of password salt (expected 128 bytes).", nameof(storedSalt));
            }

            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (var i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
