using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSCMovie.Models;
using System.Text.Encodings.Web;
using NSCMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

namespace NSCMovie.Controllers
{
    public class AdminController : Controller
    {
        private NSCMovieDbContext _context;
        private UserManager<Buyer> _userManager;
         public AdminController(NSCMovieDbContext context, UserManager<Buyer> userManager)
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
                        select m;

            var movieDaysVM = new Schedule
            {
                Days = new SelectList(await daysQuery.Distinct()
                .ToListAsync()),
                Movies = await movies.ToListAsync()
           };
            return View(movieDaysVM);
        }
        
        // GET: Movies/Delete/5
       public async Task<IActionResult> Delete(int? id)
       {
            if (id == null)
            {
                 return NotFound();
            }

            var movie = await _context.Movies
            .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            { 
                return NotFound();
            }
            return View(movie);
       }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, bool notUsed)
        {
           var movie = await _context.Movies.FindAsync(id);
           _context.Movies.Remove(movie);
           await _context.SaveChangesAsync();
           return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Days,Definition,Image,Price,RatingId,Room,Schedule,Title")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        private bool MovieExists(int id)
        {
            throw new NotImplementedException();
        }

        // GET: Movies/Create/5
        public IActionResult Create()
        {        
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Days,Definition,Image,Price,RatingId,Room,Schedule,Title")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}