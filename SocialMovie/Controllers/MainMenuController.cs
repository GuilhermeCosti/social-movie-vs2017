using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Controllers
{
    public class MainMenuController : Controller
    {
        private SocialMovieContext _context;

        public MainMenuController(SocialMovieContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        
        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Movie> data = _context.Movies.ToList();
            return View(data);
        }
    }


}
