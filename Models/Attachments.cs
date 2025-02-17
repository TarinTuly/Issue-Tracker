using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Issue.Models
{
    public class Attachments
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(300)]
        public string? FilePath { get; set; }

        [Required]
        public int IssueId { get; set; }

        [ForeignKey("IssueId")]
        public  Issues? Issue { get; set; }
    }
}
