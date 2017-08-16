using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public IActionResult Index(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            //List<Archive> file = _context.Archives.ToList();
            if (movie == null)
            {
                return PlayerError();
            }

            if (movie.Type == ContentType.Movie)
            {

            }
            return View(movie);
        }

        [Authorize]
        public IActionResult PlayerError()
        {
            return View();
        }
    }
}
