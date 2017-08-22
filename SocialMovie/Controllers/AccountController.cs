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
using System.Net.Http;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace SocialMovie.Controllers
{
    public class AccountController : Controller
    {
        private SocialMovieContext _context;
        private EmailSettings _emailSettings;

        public AccountController(SocialMovieContext context, IOptions<EmailSettings> emailSettings)
        {
            _context = context;
            _emailSettings = emailSettings.Value;
        }

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

            if(UserValidation.AuthenticUser(_context, username, password))
            {
  
                await HttpContext.Authentication.SignInAsync("CookieAuthentication", UserValidation.UserPrincipal(username));

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
            string email = HttpContext.Request.Form["email"];

            if(UserValidation.UserExists(_context, username))
            {
                ViewBag.Message = "Usuário já existente";
            }
            else
            {

                User user = UserValidation.CreateUser(username, password, email);

                SendEmailTo(email, username, password, _emailSettings);

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public void SendEmailTo(string emailAddress, string username, byte[] password, EmailSettings emailSettings)
        {

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(emailSettings.From),
                Body = $"Voce recebeu este email pois se registrou em SocialMovie. Parabéns! Seu usuário está cadastrado com sucesso! Usuário: {username}, Senha: {Encoding.ASCII.GetString(password)}",
                Subject = "Cadastro SocialMovie"
            };
            mailMessage.To.Add(emailAddress);


            SmtpClient client = new SmtpClient(emailSettings.Server, emailSettings.Port)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(emailSettings.Login, emailSettings.Password)
            };

            client.SendCompleted += (s, e) =>
            {
                client.Dispose();
                mailMessage.Dispose();
            };

            client.SendAsync(mailMessage, null);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
