using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSCMovie.Models;
using System.Text.Encodings.Web;
using NSCMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;

namespace NSCMovie.Controllers
{
    public class MovieController : Controller
    {
        private UserManager<Buyer> _userManager;
        private NSCMovieDbContext _context;
        public MovieController(NSCMovieDbContext context, UserManager<Buyer> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movie()
        {
            return View();
        }
        
    }
}