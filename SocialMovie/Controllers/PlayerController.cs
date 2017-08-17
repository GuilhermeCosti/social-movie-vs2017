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
        public IActionResult Index(int id, ContentType type)
        {
            switch (type)
            {
                case ContentType.Movie:
                    return RedirectToAction("PlayerMovie", new { id = id });
                case ContentType.Episode:
                    return RedirectToAction("ViewSerie", new { id = id });
                default:
                    break;
            }

            return PlayerError();
        }

        [Authorize]
        public IActionResult PlayerError()
        {
            return View();
        }

        [Authorize]
        public IActionResult ViewSerie(int id)
        {
            Serie serie = _context.Series
                .Include(s => s.Episodes)
                .FirstOrDefault(s => s.Id == id);
            return View(serie);
        }

        [Authorize]
        public IActionResult PlayerEpisode(int id)
        {
            var episode = _context.Episodes
                .Include(e => e.VideoFile)
                .FirstOrDefault(e => e.Id == id);
            return View(episode);
        }

        [Authorize]
        public IActionResult PlayerMovie(int id)
        {
            Movie movie = _context.Movies
              .Include(m => m.VideoFile)
              .Include(m => m.Thumbnail)
              .FirstOrDefault(m => m.Id == id);
            return View(movie);
        }
    }
}
