using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Models;
using PracticeProject.Data.Configurations;

namespace PracticeProject.Data
{
    public class MyProjectDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ProjectConfiguration());

            builder
                .ApplyConfiguration(new UserConfiguration());
        }
    }
}
