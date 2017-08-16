using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class SocialMovieContext : DbContext
    {

        public SocialMovieContext(DbContextOptions<SocialMovieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .Property(r => r.Likes)
                .HasDefaultValue(0);

            modelBuilder.Entity<Review>()
                .Property(r => r.Deslikes)
                .HasDefaultValue(0);

            modelBuilder.Entity<Movie>()
                .Property(r => r.Star1)
                .HasDefaultValue(0);

            modelBuilder.Entity<Movie>()
                .Property(r => r.Star2)
                .HasDefaultValue(0);

            modelBuilder.Entity<Movie>()
                .Property(r => r.Star3)
                .HasDefaultValue(0);

            modelBuilder.Entity<Movie>()
                .Property(r => r.Star4)
                .HasDefaultValue(0);

            modelBuilder.Entity<Movie>()
                .Property(r => r.Star5)
                .HasDefaultValue(0);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Archive> Archives { get; set; }
        public DbSet<Content> Contents { get; set; }
    }
}