using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialMovie.Models;

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
            //IEnumerable<Movie> data = _context.Movies.ToList();
            //return View(data);
            return RedirectToAction("Login", "Account");
        }
    }
}
