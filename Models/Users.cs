using System.ComponentModel.DataAnnotations;

namespace Issue.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Store hashed password

        [Required]
        public string UserType { get; set; } // "Admin", "Developer", "Reporter"
    }
}
