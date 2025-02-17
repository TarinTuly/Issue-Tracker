using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Issue.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Content { get; set; }

        [Required]
        public int IssueId { get; set; }

        [ForeignKey(nameof(IssueId))]
        public  Issues? Issue { get; set; }

        [Required]
        public int CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public  Users? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } 
    }
}
