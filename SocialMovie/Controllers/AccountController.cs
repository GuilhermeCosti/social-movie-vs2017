using System;
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
                ViewBag.Message = "Cadastrado!";
            }
            else
            {
                ViewBag.Message = "Não Cadastrado!";
            }

            return View();
        }

        private static byte[] Encrypt(byte[] password)
        {
            SHA512 sha = SHA512.Create();
            return sha.ComputeHash(password);
        }

        private static bool AuthenticUser(SocialMovieContext context, string username, byte[] password)
        {
            User dbUser = context.Users.FirstOrDefault(x => x.UserName == username);

            if (dbUser != null)
            {
                string passdb = Encoding.ASCII.GetString(dbUser.Password);
                string passuser = BitConverter.ToString(Encrypt(password)).Replace("-", "");

                if (passdb == passuser)
                {
                    return true; 
                }
            }

            return false;
        }
    }
}
