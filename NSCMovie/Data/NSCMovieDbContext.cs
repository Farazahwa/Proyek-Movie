using Microsoft.EntityFrameworkCore;
using NSCMovie.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NSCMovie.Data
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