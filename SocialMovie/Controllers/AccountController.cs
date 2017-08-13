﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using SocialMovie.Models;
using Microsoft.EntityFrameworkCore;


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
        public IActionResult LoginReturn()
        {
            string username = HttpContext.Request.Form["username"];
            byte[] password = Encoding.ASCII.GetBytes(HttpContext.Request.Form["password"]);

            if(AuthenticUser(_context, username, password))
            {
                ViewBag.Message = "Entrou no sistema!";
            }
            else
            {
                ViewBag.Message = "Usuario ou senha incorretos!";
            }

            return View();
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

                User user = new User();
                user.UserName = username;
                user.Password = userPassword;
                user.Salt = salt;
                user.Birthday = DateTime.Now;

                _context.Users.Add(user);
                _context.SaveChanges();

                ViewBag.Message = "Usuário inserido com sucesso!";
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
