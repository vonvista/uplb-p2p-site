using System.ComponentModel.DataAnnotations;

namespace UPLB_P2P.Website.Models.Domain
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation Property
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Vote> Votes { get; set; }

    }
}
