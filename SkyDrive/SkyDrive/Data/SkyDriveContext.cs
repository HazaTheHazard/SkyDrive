using SkyDrive.Models;
using Microsoft.EntityFrameworkCore;

namespace SkyDrive.Models
{
    public class SkyDriveContext : DbContext
    {
        public SkyDriveContext(DbContextOptions<SkyDriveContext> options) : base(options)
        {
        }

        public DbSet<Auth> Auth { get; set; }
        public DbSet<Note> Note { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auth>().ToTable("Auth");
            modelBuilder.Entity<Note>().ToTable("Note");
        }
    }
}