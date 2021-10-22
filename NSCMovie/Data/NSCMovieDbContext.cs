using Microsoft.EntityFrameworkCore;
using NSCMovie.Models;
namespace MvcMovie.Data
{
    public class NSCMovieDbContext : DbContext
    {
       public NSCMovieDbContext (DbContextOptions<NSCMovieDbContext> options) : base(options)
       {}
       public DbSet<Movie> Movies { get; set; }
    }
}