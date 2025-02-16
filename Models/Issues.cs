using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Issue.Models
{
    public class Issues
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public bool IsOngoing { get; set; } // True = Ongoing, False = Resolved

        [Required]
        public int ProjectId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public required Projects Project { get; set; }

        [Required]
        public int CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public required Users CreatedBy { get; set; }

        public ICollection<Comments> Comments { get; set; } = new List<Comments>();
        public ICollection<Attachments> Attachments { get; set; } = new List<Attachments>();
        public ICollection<IssueHistory> IssueHistories { get; set; } = new List<IssueHistory>();
    }
}
