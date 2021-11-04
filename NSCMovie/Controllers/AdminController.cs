using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSCMovie.Data;
using NSCMovie.Models;

namespace NSCMovie.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<Buyer> _userManager;
        private NSCMovieDbContext _context;
        public AdminController(NSCMovieDbContext context, UserManager<Buyer> userManager)
        {
            _context = context;
            _userManager = userManager;
        }            


    }  
}