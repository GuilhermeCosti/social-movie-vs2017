using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialMovie.Controllers
{
    public class WatchMovieController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string id)
        {
            ViewData["Id"] = id;
            return View();
        }

        //public string Index(int id)
        //{
        //    return id.ToString();
        //}
    }
}
