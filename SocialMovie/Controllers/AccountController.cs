using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using SocialMovie.Models;
using SocialMovie.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialMovie.Controllers
{
    public class AccountController : Controller
    {
        private SocialMovieContext _context;

        public AccountController(SocialMovieContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginReturn()
        {
            string username = HttpContext.Request.Form["username"];
            byte[] password = Encoding.ASCII.GetBytes(HttpContext.Request.Form["password"]);

            if(AuthenticUser(_context, username, password))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.Authentication.SignInAsync("CookieAuthentication", principal);

                return RedirectToAction("Index", "MainMenu");
            }
            else
            {
                ViewBag.Message = "Usuario ou senha incorretos!";
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.Authentication.SignOutAsync("CookieAuthentication");
            return Redirect("/Account/Login");
        }

        [HttpPost]
        public IActionResult RegisterReturn()
        {
            string username = HttpContext.Request.Form["username"];
            byte[] password = Encoding.ASCII.GetBytes(HttpContext.Request.Form["password"]);

            if(UserExists(_context, username))
            {
                ViewBag.Message = "Usuário já existente";
            }
            else
            {
                byte[] salt = GetSalt();
                byte[] hashedPassword = GetHash(password);
                IEnumerable<byte> saltedHash = hashedPassword.Concat(salt);
                byte[] userPassword = GetHash(saltedHash.ToArray());

                User user = new User
                {
                    UserName = username,
                    Password = userPassword,
                    Salt = salt,
                    Birthday = DateTime.Now
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Login", "Account");
                //ViewBag.Message = "Usuário inserido com sucesso!";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        private static bool UserExists(SocialMovieContext context, string username)
        {
            int count = context.Users.Count(x => x.UserName == username);
            return count > 0 ? true : false;
        }

        private static byte[] GetHash(byte[] password)
        {
            SHA512 sha = SHA512.Create();
            return sha.ComputeHash(password);
        }

        private static bool AuthenticUser(SocialMovieContext context, string username, byte[] password)
        {
            User dbUser = context.Users.FirstOrDefault(x => x.UserName == username);

            if (dbUser != null)
            {
                byte[] passwordHash = GetHash(password);
                IEnumerable<byte> saltedHash = passwordHash.Concat(dbUser.Salt);
                
                string saltedHashUser = Encoding.ASCII.GetString(GetHash(saltedHash.ToArray()));
                string saltedHashDB = Encoding.ASCII.GetString(dbUser.Password);
                //string passhash = BitConverter.ToString(Encrypt(password)).Replace("-", "");

                if (saltedHashUser == saltedHashDB)
                {
                    return true; 
                }
            }

            return false;
        }

        private static byte[] GetSalt()
        {
            byte[] bytes = new byte[64];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytes);
                //return BitConverter.ToString(bytes).Replace("-", "");
                return bytes;
            }
        }
    }
}
