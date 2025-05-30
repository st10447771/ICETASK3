using Microsoft.EntityFrameworkCore;
namespace CullenInternshipInitiative.Models
{
    
  
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<Students> Students { get; set; }
            public DbSet<Companies> Companies { get; set; }
            public DbSet<Internship> Internships { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Students>().ToTable("Students");
                modelBuilder.Entity<Companies>().ToTable("Companies");
                modelBuilder.Entity<Internship>().ToTable("Internships");
            }
    }
}

