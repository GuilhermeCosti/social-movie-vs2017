using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialMovie.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Hash()
        {
            // Generating salt
            var salt = new byte[256];
            var rand = new Random();
            for (int i = 0; i < 256; i++)
            {
                salt[i] = byte.Parse(rand.Next(48, 122).ToString());
            }

            ViewBag.Salt = System.Text.Encoding.ASCII.GetString(salt);

            return View();
        }

        [HttpPost]
        public IActionResult CheckSalt()
        {
            string salt = HttpContext.Request.Form["salt"];
            string hash = HttpContext.Request.Form["hash"];

            return View();
        }
    }
}
