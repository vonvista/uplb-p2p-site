using System.ComponentModel.DataAnnotations;

namespace UPLB_P2P.Website.Models.Domain
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProfessorId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public decimal Rating { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation Property
        public User User { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Vote> Votes { get; set; }

        public bool IsDeleted { get; set; }
    }
}
