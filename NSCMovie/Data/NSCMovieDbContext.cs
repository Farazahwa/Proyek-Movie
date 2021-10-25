using Microsoft.EntityFrameworkCore;
using NSCMovie.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcMovie.Data
=======
namespace NSCMovie.Data
>>>>>>> c2a6a548f094e656c07bcace38908e4a2a0db2f8
{
    public class NSCMovieDbContext : IdentityDbContext<Buyer>
    {
       public NSCMovieDbContext (DbContextOptions<NSCMovieDbContext> options) : base(options)
       {}
       public DbSet<Movie> Movies { get; set; }
       public DbSet<TranksaksiMovie> TranksaksiMovies { get; set; }
       public DbSet<Transaction> Transactions { get; set; }
       public DbSet<Rank> Ranks { get; set; }
    }
}