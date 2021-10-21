using PracticeProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PracticeProject.Data.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.StartDate)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasOne(m => m.User)
                .WithMany(a => a.Projects)
                .HasForeignKey(m => m.Id);

            builder
                .ToTable("Projects");
        }
    }
}