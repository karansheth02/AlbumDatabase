using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace AlbumApp.Entities
{
    public class AlbumsDbContext : DbContext
    {
       
        public AlbumsDbContext(DbContextOptions<AlbumsDbContext> options) : base(options)
        {

        }
        // Add your properties for accessing your entities here...
        public DbSet<Album>? Albums { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Do your initializing/seeding here...
            modelBuilder.Entity<Album>().HasData(
               new Album { Id = 1, Title = "To Seek the Truth of The Cosmos", Author= "The Clash", Song= "Lost In The Supermarket", Rating= 9.8M } ,
               new Album { Id = 2, Title = "Beyond The Veil of Time", Author= "George Harrison", Song= "All Things Must Pass", Rating= 9.5M },
               new Album { Id = 3, Title = "Bad Company", Author= "The Beatles", Song= "Let It Be", Rating= 9.5M },
               new Album { Id = 4, Title = "Ready, Set, Go!", Author= "John Lennon", Song= "Imagine", Rating= 9.1M },
               new Album { Id = 5, Title = "The Rhythm of Life", Author= "Elton John", Song= "Your Song", Rating= 8.8M }  
                
           );
        }
    }
}
