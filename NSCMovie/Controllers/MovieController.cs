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

        public async Task<IActionResult> Index(string movieDays)
        {
            IQueryable<string> daysQuery = from m in _context.Movies
                                    orderby m.Days
                                    select m.Days;

            var today = DateTime.Today.DayOfWeek.ToString();
            var movies = from m in _context.Movies
                        where m.Days == today
                        select new MovieListViewModel {
                            Image = m.Image,
                            Definition = m.Definition,
                            Title = m.Title,
                            Id = m.Id
                        };

            var movieDaysVM = new Schedule
            {
                Days = new SelectList(await daysQuery.Distinct()
                .ToListAsync()),
                MovieLists = movies.ToList().GroupBy(x=>new {x.Title, x.Image, x.Definition}).Select(x=>x.FirstOrDefault()).ToList()
            };
            return View(movieDaysVM);
        }

        public IActionResult Movie(int? id)
        {
            if(id == null)
            {
                return NotFound();                
            }
            var movie = _context.Movies.Find(id);
            if(movie == null)
            {
                return NotFound();
            }
            var movies = new MovieViewModel()
            {
                Movie = movie,
                TimeSchedule = _context.TimeSchedules.ToList()
            };
            return View(movies);
        }
    }
}