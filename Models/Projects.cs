using System.ComponentModel.DataAnnotations;

namespace Issue.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public required string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public  ICollection<Issues> Issues { get; set; }
    }
}
