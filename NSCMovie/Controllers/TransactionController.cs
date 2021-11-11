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

        public IActionResult Create(int id)
        {
            var MovieTransactionVM = new MovieTransactionViewModel
            {
                Movie = _context.Movies.Find(id),                
            };
            return View(MovieTransactionVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(Prefix = "TranksaksiMovie")] AddTransactionViewModel movieTransaction, int id)
        {            
            var dataMovie = _context.Movies.Find(id);            
            var userId = _userManager.GetUserId(User);
            if(!ModelState.IsValid)
            {
                return NotFound();
            }            
            var transactions = new List<TranksaksiMovie>();
            var newTransaction = new Transaction()
            {
                Date = DateTime.UtcNow,         
                Payment = movieTransaction.Payment,                                    
                PenggunaId = userId,
            };
            var addTransaction = new TranksaksiMovie()
            {                
                Price = dataMovie.Price,             
                MovieId = id, 
                Transaction = newTransaction,
                TicketAmount = movieTransaction.TicketAmount,                                
                TransactionDate = DateTime.UtcNow,
                Time = movieTransaction.Time,
            };
            
            transactions.Add(addTransaction);            
            newTransaction.TranksaksiMovies = transactions;

            _context.Transactions.Add(newTransaction);
            await _context.SaveChangesAsync();            
            return RedirectToAction("Index", "Movie", "movieDays");
        }
    }
}