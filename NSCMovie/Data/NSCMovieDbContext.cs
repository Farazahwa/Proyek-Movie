using Microsoft.EntityFrameworkCore;
using NSCMovie.Models;
namespace NSCMovie.Data
{
    public class NSCMovieDbContext : DbContext
    {
       public NSCMovieDbContext (DbContextOptions<NSCMovieDbContext> options) : base(options)
       {}
       public DbSet<Movie> Movies { get; set; }
       public DbSet<TranksaksiMovie> TranksaksiMovies { get; set; }
       public DbSet<Transaction> Transactions { get; set; }
       public DbSet<Rank> Ranks { get; set; }
       public DbSet<Buyer> Buyers { get; set; }
    }
}