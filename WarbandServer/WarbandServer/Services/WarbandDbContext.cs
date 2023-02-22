using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WarbandServer.Models;

namespace WarbandServer.Services
{
    public class WarbandContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public WarbandContext(DbContextOptions<WarbandContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Dummy data
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Test User 1", Pass = "Non-hashed-password1", Mail = "testmail1.com" },
                new User { Id = 2, Name = "Test User 2", Pass = "Non-hashed-password2", Mail = "testmail2.com" }
                );
        }
    }
}
