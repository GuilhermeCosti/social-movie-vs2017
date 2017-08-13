using Microsoft.AspNetCore.Mvc;
using SocialMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Controllers
{
    public class PlayerController : Controller
    {
        private SocialMovieContext _context;

        public PlayerController(SocialMovieContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if(movie == null)
            {
                return PlayerError();
            }
            return View(movie);
        }

        public IActionResult PlayerError()
        {
            return View();
        }
    }
}
