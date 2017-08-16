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

            Content split =_context.Contents.FirstOrDefault(c => c.Name == "Split");
            if(split == null)
            {
                var movie = new Movie()
                {
                    Name = "Split",
                    Description = "Rapaz que rouba mocas",
                    Type = ContentType.Movie,
                    Thumbnail = new Archive()
                    {
                        Name = "split",
                        Path = "split/",
                        Extension = ".jpg",
                        Type = ArchiveType.Image
                    },
                    VideoFile = new Archive()
                    {
                        Name = "stream",
                        Path = "split/video",
                        Extension = "mpd",
                        Type = ArchiveType.Video
                    },
                    Star1 = 10,
                    Star2 = 20,
                    Star3 = 30,
                    Star4 = 40,
                    Star5 = 50
                };

                _context.Contents.Add(movie);
                _context.SaveChanges();
            }


        }

        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Login", "Account");
        }
    }
}
