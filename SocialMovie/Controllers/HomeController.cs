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


            Content split =_context.Contents.FirstOrDefault(c => c.Name == "Split");
            if (split == null)
            {
                _context.Contents.Add(movie);
            }

            var jerrygoround = new Archive()
            {
                Extension = "mpd",
                Name = "JerryGoRound_vod",
                Path = "JerryGoRound_output"
            };

            var justducky = new Archive()
            {
                Extension = "mpd",
                Name = "JustDucky_vod",
                Path = "JustDucky_output"
            };

            var episodes = new List<Episode>();
            episodes.Add(new Episode() { ENumber = 1, SNumber = 1, VideoFile = jerrygoround });
            episodes.Add(new Episode() { ENumber = 2, SNumber = 2, VideoFile = justducky });

            var serie = new Serie()
            {
                Name = "Tom and Jerry",
                Description = "Gato e rato",
                Type = ContentType.Episode,
                Thumbnail = new Archive()
                {
                    Name = "tom",
                    Path = "jerry/",
                    Extension = ".jpg",
                    Type = ArchiveType.Image
                },
                Episodes = episodes,
                Star1 = 10,
                Star2 = 20,
                Star3 = 30,
                Star4 = 40,
                Star5 = 50
            };

            Content tomjerry = _context.Contents.FirstOrDefault(c => c.Name == "Tom and Jerry");
            if (tomjerry == null)
            {
                _context.Contents.Add(serie);
            }

            Review review = new Review()
            {
                ArchiveId = movie.Id,
                ReviewerId = 1,
                Body = "Esse filme é muito bom. Ótimas atuações",
                Likes = 100,
                Deslikes = 2,
                Title = "Rapaz mestre",
                Rating = Rating.Excellent
            };

            //_context.Reviews.Add(review);
            

            _context.SaveChanges();

        }

        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Login", "Account");
        }
    }
}
