using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public static class UserValidation
    {
        public static ClaimsPrincipal UserPrincipal(string username)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

            var userIdentity = new ClaimsIdentity(claims, "login");

            return new ClaimsPrincipal(userIdentity);
        }
        public static User CreateUser(string username, byte[] password, string email)
        {
            byte[] salt = GetSalt();
            byte[] userPassword = SaltPassword(password, salt);

            User user = new User
            {
                UserName = username,
                Password = userPassword,
                Salt = salt,
                Birthday = DateTime.Now
            };

            return user;
        }

        public static byte[] SaltPassword(byte[] password, byte[] salt)
        {
            byte[] hashedPassword = GetHash(password);
            IEnumerable<byte> saltedHash = hashedPassword.Concat(salt);

            return GetHash(saltedHash.ToArray());
        }

        public static bool UserExists(SocialMovieContext context, string username)
        {
            int count = context.Users.Count(x => x.UserName == username);
            return count > 0 ? true : false;
        }

        public static byte[] GetHash(byte[] password)
        {
            SHA512 sha = SHA512.Create();
            return sha.ComputeHash(password);
        }

        public static bool AuthenticUser(SocialMovieContext context, string username, byte[] password)
        {
            User dbUser = context.Users.FirstOrDefault(x => x.UserName == username);

            if (dbUser != null)
            {
                byte[] passwordHash = GetHash(password);
                IEnumerable<byte> saltedHash = passwordHash.Concat(dbUser.Salt);

                string saltedHashUser = Encoding.ASCII.GetString(GetHash(saltedHash.ToArray()));
                string saltedHashDB = Encoding.ASCII.GetString(dbUser.Password);

                if (saltedHashUser == saltedHashDB)
                {
                    return true;
                }
            }

            return false;
        }

        public static byte[] GetSalt()
        {
            byte[] bytes = new byte[64];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytes);
                return bytes;
            }
        }
    }
}
