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
using System.IO;
using Microsoft.AspNetCore.StaticFiles;


namespace NSCMovie.Controllers
{
    public class AdminController : Controller
    {
         private NSCMovieDbContext _context;
         public AdminController(NSCMovieDbContext context)
        {
            _context = context;
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

        public async Task<IActionResult> Create(int? id)
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
            return View(movie);
        }
    }
  
}