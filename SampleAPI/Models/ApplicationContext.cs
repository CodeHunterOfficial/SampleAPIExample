using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Name = "Annya", Age = 18 },
                    new User { Id = 2, Name = "Margarita", Age = 18 },
                    new User { Id = 3, Name = "Valeriya", Age = 18 }
            );
        }
    }
}