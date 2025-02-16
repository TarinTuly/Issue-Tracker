using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Issue.Models
{
    public class IssueHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IssueId { get; set; }

        [ForeignKey("IssueId")]
        public required Issues Issue { get; set; }

        [Required, MaxLength(100)]
        public required string StatusChange { get; set; } // e.g., "Opened", "In Progress", "Resolved"

        [Required]
        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    }
}
