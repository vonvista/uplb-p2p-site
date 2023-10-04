using System.ComponentModel.DataAnnotations;

namespace UPLB_P2P.Website.Models.Domain
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int UserId { get; set; }

        [Required]
        public int ReviewId { get; set; }

        public int? ParentId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation Property
        public User User { get; set; }
        public Review Review { get; set; }
        //public Comment ParentComment { get; set; }
        //public ICollection<Comment> ChildComments { get; set; }
        public ICollection<Vote> Votes { get; set; }
        public bool IsDeleted { get; set; }

    }
}
