using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ExploreUmami.Common.ValidationConstants.Review;

namespace ExploreUmami.Data.Models 

{
    public class Review
    {

        public Review()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(SubjectMaxLength)]
        public string Subject { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        [Required]
        [Range(MinRating, MaxRating)]
        public double Rating { get; set; }

        public string? UserLocation { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime TimeStamp { get; set; }

        [ForeignKey(nameof(Business))]
        public Guid BusinessId { get; set; }

        public Business Business { get; set; } = null!;

        [ForeignKey(nameof(Reviewer))]
        public Guid ReviewerId { get; set; }

        public virtual ApplicationUser Reviewer { get; set; } = null!;
    }
}