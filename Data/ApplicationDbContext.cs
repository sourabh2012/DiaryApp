using DiaryApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with joe",
                    Created = DateTime.Now
                },
                new DiaryEntry 
                {
                    Id = 2,
                    Title = "Went Shopping",
                    Content = "Went Shopping with joe",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Divivg",
                    Content = "Went Diving with joe",
                    Created = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 4,
                    Title = "Went Dancing",
                    Content = "Went Dancing with joe",
                    Created = DateTime.Now
                }
                );
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        // Use this method if options are not configured elsewhere (e.g. in Startup.cs)
        //        optionsBuilder.UseSqlServer("Server=DESKTOP-KPM0SP1\\SQLEXPRESS;Database=Diary;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");

        //        // Optionally, configure warnings (e.g. ignore pending model changes warning)
        //        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //    }
        //}
    }
}
