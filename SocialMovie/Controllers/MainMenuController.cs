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
            IEnumerable<Content> contents= _context.Contents.ToList();
            return View(contents);
        }
    }


}
