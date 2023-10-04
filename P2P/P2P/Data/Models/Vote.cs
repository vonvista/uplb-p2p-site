using System.ComponentModel.DataAnnotations;

namespace UPLB_P2P.Website.Models.Domain
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        [Required]
        public int UserId { get; set; }

        public int? ReviewId { get; set; }

        public int? CommentId { get; set; }

        [Required]
        public string VoteType { get; set; }

        // Navigation Property
        public User User { get; set; }
        public Review Review { get; set; }
        public Comment Comment { get; set; }

    }
}
