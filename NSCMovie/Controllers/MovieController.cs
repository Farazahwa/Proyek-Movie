using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSCMovie.Models;
using System.Text.Encodings.Web;
using MvcMovie.Data;

namespace NSCMovie.Controllers
{
    public class MovieController : Controller
    {
        private NSCMovieDbContext _context;
        public MovieController(NSCMovieDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Movies.ToList());
        }

        public IActionResult MovieOne()
        {
            return View();
        }
    }
}