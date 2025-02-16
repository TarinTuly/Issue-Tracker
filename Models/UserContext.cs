using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace Issue.Models
{
    public class UserContext :DbContext
    {
        public UserContext(DbContextOptions options):base(options) 
        { 
        }
        public DbSet<Users>Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Issues> Issues { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Attachments> Attachments { get; set; }
        public DbSet<IssueHistory> IssueHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>()
                .HasOne(c => c.Issue)
                .WithMany(i => i.Comments)
                .HasForeignKey(c => c.IssueId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete

            modelBuilder.Entity<Comments>()
                .HasOne(c => c.CreatedBy)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.CreatedById)
                .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete
        }
    }
}
