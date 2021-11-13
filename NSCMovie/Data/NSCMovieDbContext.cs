using Microsoft.EntityFrameworkCore;
using NSCMovie.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace NSCMovie.Data
{
    public class NSCMovieDbContext : IdentityDbContext<Buyer>
    {
       public NSCMovieDbContext (DbContextOptions<NSCMovieDbContext> options) : base(options)
       {}
       public DbSet<Movie> Movies { get; set; }
       public DbSet<TimeSchedule> TimeSchedules { get; set; }
       public DbSet<TranksaksiMovie> TranksaksiMovies { get; set; }
       public DbSet<Transaction> Transactions { get; set; }
       public DbSet<Rank> Ranks { get; set; }
       protected override void OnModelCreating(ModelBuilder builder)
       {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(new [] {
                    new IdentityRole("Admin")
                });
            
            var hasher = new PasswordHasher<Buyer>();
            var admin = new Buyer{
                UserName = "AdminWibu",
                NormalizedUserName = "ADMINWIBU",
                Email = "AdminWibu@admin.com",
                NormalizedEmail = "ADMINWIBU@ADMIN.COM",
                EmailConfirmed = true
            };

            admin.PasswordHash = hasher.HashPassword(admin, "12345678");
            builder.Entity<Buyer>()
                .HasData(admin);
       }
    }
}