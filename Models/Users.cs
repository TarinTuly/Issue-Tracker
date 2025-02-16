using System.ComponentModel.DataAnnotations;

namespace Issue.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        [Required, MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string PasswordHash { get; set; } // Store hashed password

        [Required]
        [MaxLength(50)]
        public required string UserType { get; set; } // "Admin", "Developer", "Reporter"

        public ICollection<Issues> IssuesCreated { get; set; } = new List<Issues>();
        public ICollection<Comments> Comments { get; set; } = new List<Comments>();
    }
}
