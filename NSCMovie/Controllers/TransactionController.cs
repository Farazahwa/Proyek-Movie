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
using Microsoft.AspNetCore.Authorization;

namespace NSCMovie.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private UserManager<Buyer> _userManager;
        private NSCMovieDbContext _context;
        public TransactionController(NSCMovieDbContext context, UserManager<Buyer> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, TicketAmount")] TranksaksiMovie movieTransaction, int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var dataMovie = _context.Movies.Find(id);
            if(!ModelState.IsValid)
            {
                return NotFound();
            }            

            var transactions = new List<TranksaksiMovie>();
            var newTransaction = new Transaction()
            {
                Date = DateTime.UtcNow,                                                                  
            };
            var addTransaction = new TranksaksiMovie()
            {
                Price = dataMovie.Price,                                
            };
            
            transactions.Add(addTransaction);
            transactions.Add(movieTransaction);
            newTransaction.TranksaksiMovies = transactions;

            _context.Transactions.Add(newTransaction);
            _context.SaveChanges();            
            return RedirectToAction("Movie", "MovieController");
        }
    }
}