using SkyDrive.Models;
using Microsoft.EntityFrameworkCore;

namespace SkyDrive.Models
{
    public class SkyDriveContext : DbContext
    {
        public SkyDriveContext(DbContextOptions<SkyDriveContext> options) : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<FileMapping> FileMapping { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Note>().ToTable("Note");
            modelBuilder.Entity<FileMapping>().ToTable("FileMapping");
        }
    }
}