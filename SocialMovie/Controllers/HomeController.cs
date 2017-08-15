using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialMovie.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialMovie.Controllers
{
    public class HomeController : Controller
    {
        private SocialMovieContext _context;

        public HomeController(SocialMovieContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Index", "MainMenu");
        }
    }
}
