using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            Movie movie = _context.Movies
                .Include(m => m.VideoFile)
                .Include(m => m.Thumbnail)
                .FirstOrDefault(m => m.Id == id); 

            if (movie == null)
            {
                return PlayerError();
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
