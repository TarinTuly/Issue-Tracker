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


            modelBuilder.Entity<Users>().HasData(
               new Users { Id = 1, Name = "Alice Smith", Email = "alice@example.com", PasswordHash = "hashedpass1", UserType = "Admin" },
               new Users { Id = 2, Name = "Bob Johnson", Email = "bob@example.com", PasswordHash = "hashedpass2", UserType = "Developer" },
               new Users { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", PasswordHash = "hashedpass3", UserType = "Reporter" },
               new Users { Id = 4, Name = "David Miller", Email = "david@example.com", PasswordHash = "hashedpass4", UserType = "Tester" },
               new Users { Id = 5, Name = "Eva Green", Email = "eva@example.com", PasswordHash = "hashedpass5", UserType = "Manager" },
               new Users { Id = 6, Name = "Frank White", Email = "frank@example.com", PasswordHash = "hashedpass6", UserType = "Developer" },
               new Users { Id = 7, Name = "Grace Adams", Email = "grace@example.com", PasswordHash = "hashedpass7", UserType = "Designer" },
               new Users { Id = 8, Name = "Hannah Lee", Email = "hannah@example.com", PasswordHash = "hashedpass8", UserType = "Admin" },
               new Users { Id = 9, Name = "Ian Black", Email = "ian@example.com", PasswordHash = "hashedpass9", UserType = "QA" },
               new Users { Id = 10, Name = "Jack Taylor", Email = "jack@example.com", PasswordHash = "hashedpass10", UserType = "Developer" }
           );
            modelBuilder.Entity<Projects>().HasData(
             new Projects { Id = 1, Name = "Project Alpha", Description = "First project" },
             new Projects { Id = 2, Name = "Project Beta", Description = "Second project" },
             new Projects { Id = 3, Name = "Project Gamma", Description = "Third project" },
             new Projects { Id = 4, Name = "Project Delta", Description = "Fourth project" },
             new Projects { Id = 5, Name = "Project Epsilon", Description = "Fifth project" },
             new Projects { Id = 6, Name = "Project Zeta", Description = "Sixth project" },
             new Projects { Id = 7, Name = "Project Eta", Description = "Seventh project" },
             new Projects { Id = 8, Name = "Project Theta", Description = "Eighth project" },
             new Projects { Id = 9, Name = "Project Iota", Description = "Ninth project" },
             new Projects { Id = 10, Name = "Project Kappa", Description = "Tenth project" }
         );
            modelBuilder.Entity<Issues>().HasData(
               new Issues { Id = 1, Title = "Login Bug", Description = "Users can't log in", IsOngoing = true, ProjectId = 1, CreatedById = 1 },
               new Issues { Id = 2, Title = "UI Glitch", Description = "Alignment issue", IsOngoing = true, ProjectId = 2, CreatedById = 2 },
               new Issues { Id = 3, Title = "Performance Issue", Description = "Slow response", IsOngoing = false, ProjectId = 3, CreatedById = 3 },
               new Issues { Id = 4, Title = "Security Vulnerability", Description = "Data leak risk", IsOngoing = true, ProjectId = 4, CreatedById = 4 },
               new Issues { Id = 5, Title = "Database Crash", Description = "DB service down", IsOngoing = false, ProjectId = 5, CreatedById = 5 },
               new Issues { Id = 6, Title = "API Timeout", Description = "API requests failing", IsOngoing = true, ProjectId = 6, CreatedById = 6 },
               new Issues { Id = 7, Title = "Memory Leak", Description = "High RAM usage", IsOngoing = false, ProjectId = 7, CreatedById = 7 },
               new Issues { Id = 8, Title = "Broken Link", Description = "404 error", IsOngoing = true, ProjectId = 8, CreatedById = 8 },
               new Issues { Id = 9, Title = "Mobile UI Issue", Description = "Buttons not responsive", IsOngoing = false, ProjectId = 9, CreatedById = 9 },
               new Issues { Id = 10, Title = "Deployment Failure", Description = "CI/CD error", IsOngoing = true, ProjectId = 10, CreatedById = 10 }
           );

            modelBuilder.Entity<Comments>().HasData(
      new Comments { Id = 1, Content = "Initial issue reported", IssueId = 1, CreatedById = 1, CreatedAt = new DateTime(2024, 2, 17, 10, 0, 0) },
      new Comments { Id = 2, Content = "Assigned to developer", IssueId = 1, CreatedById = 2, CreatedAt = new DateTime(2024, 2, 17, 10, 30, 0) },
      new Comments { Id = 3, Content = "Bug confirmed", IssueId = 2, CreatedById = 3, CreatedAt = new DateTime(2024, 2, 17, 11, 0, 0) },
      new Comments { Id = 4, Content = "Fix in progress", IssueId = 2, CreatedById = 4, CreatedAt = new DateTime(2024, 2, 17, 11, 30, 0) },
      new Comments { Id = 5, Content = "Fixed and committed", IssueId = 3, CreatedById = 2, CreatedAt = new DateTime(2024, 2, 17, 12, 0, 0) },
      new Comments { Id = 6, Content = "Tested and verified", IssueId = 3, CreatedById = 3, CreatedAt = new DateTime(2024, 2, 17, 12, 30, 0) },
      new Comments { Id = 7, Content = "Deployed to staging", IssueId = 4, CreatedById = 5, CreatedAt = new DateTime(2024, 2, 17, 13, 0, 0) },
      new Comments { Id = 8, Content = "Issue re-opened", IssueId = 4, CreatedById = 1, CreatedAt = new DateTime(2024, 2, 17, 13, 30, 0) },
      new Comments { Id = 9, Content = "Final fix applied", IssueId = 5, CreatedById = 2, CreatedAt = new DateTime(2024, 2, 17, 14, 0, 0) },
      new Comments { Id = 10, Content = "Closed successfully", IssueId = 5, CreatedById = 4, CreatedAt = new DateTime(2024, 2, 17, 14, 30, 0) }
  );
            modelBuilder.Entity<Attachments>().HasData(
     new Attachments { Id = 1, FilePath = "/uploads/error_log1.txt", IssueId = 1 },
     new Attachments { Id = 2, FilePath = "/uploads/screenshot_bug.png", IssueId = 1 },
     new Attachments { Id = 3, FilePath = "/uploads/stack_trace.log", IssueId = 2 },
     new Attachments { Id = 4, FilePath = "/uploads/fix_patch.diff", IssueId = 2 },
     new Attachments { Id = 5, FilePath = "/uploads/test_results.pdf", IssueId = 3 },
     new Attachments { Id = 6, FilePath = "/uploads/crash_report.txt", IssueId = 3 },
     new Attachments { Id = 7, FilePath = "/uploads/debug_log.txt", IssueId = 4 },
     new Attachments { Id = 8, FilePath = "/uploads/final_patch.zip", IssueId = 4 },
     new Attachments { Id = 9, FilePath = "/uploads/deployment_logs.txt", IssueId = 5 },
     new Attachments { Id = 10, FilePath = "/uploads/code_review.docx", IssueId = 5 }
 );
            modelBuilder.Entity<IssueHistory>().HasData(
    new IssueHistory { Id = 1, IssueId = 1, StatusChange = "Opened", ChangedAt = new DateTime(2024, 2, 1, 10, 30, 0) },
    new IssueHistory { Id = 2, IssueId = 1, StatusChange = "In Progress", ChangedAt = new DateTime(2024, 2, 2, 12, 15, 0) },
    new IssueHistory { Id = 3, IssueId = 1, StatusChange = "Resolved", ChangedAt = new DateTime(2024, 2, 3, 14, 45, 0) },
    new IssueHistory { Id = 4, IssueId = 2, StatusChange = "Opened", ChangedAt = new DateTime(2024, 2, 4, 9, 10, 0) },
    new IssueHistory { Id = 5, IssueId = 2, StatusChange = "Closed", ChangedAt = new DateTime(2024, 2, 5, 16, 20, 0) },
    new IssueHistory { Id = 6, IssueId = 3, StatusChange = "Opened", ChangedAt = new DateTime(2024, 2, 6, 11, 5, 0) },
    new IssueHistory { Id = 7, IssueId = 3, StatusChange = "In Review", ChangedAt = new DateTime(2024, 2, 7, 14, 0, 0) },
    new IssueHistory { Id = 8, IssueId = 4, StatusChange = "Opened", ChangedAt = new DateTime(2024, 2, 8, 8, 30, 0) },
    new IssueHistory { Id = 9, IssueId = 5, StatusChange = "Reopened", ChangedAt = new DateTime(2024, 2, 9, 10, 0, 0) },
    new IssueHistory { Id = 10, IssueId = 5, StatusChange = "Resolved", ChangedAt = new DateTime(2024, 2, 10, 17, 25, 0) }
);



        }
    }
}
