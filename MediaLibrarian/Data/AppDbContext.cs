using MediaLibrarian.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MediaLibrarian.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MovieModel> Movie { get; set; }
        public DbSet<BookModel> Book { get; set; }
        public DbSet<TelevisionModel> Televsion { get; set; }
        public DbSet<VideoGameModel> VideoGame { get; set; }
        public DbSet<MusicModel> Music { get; set; }
    }
}
