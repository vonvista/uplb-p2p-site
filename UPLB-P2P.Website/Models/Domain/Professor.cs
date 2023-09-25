using System.ComponentModel.DataAnnotations;

namespace UPLB_P2P.Website.Models.Domain
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Department { get; set; }

        public decimal AverageRating { get; set; }

        // Navigation Property
        public ICollection<Review> Reviews { get; set; }

    }
}
