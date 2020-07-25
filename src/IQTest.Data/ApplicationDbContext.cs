using IQTest.Core.Entities;
using IQTest.Data.Helpers;
using Microsoft.EntityFrameworkCore;

namespace IQTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasMany(e => e.Options)
                    .WithOne(e => e.Question)
                    .IsRequired();
            });

            modelBuilder.Seed();
        }
    }
}
