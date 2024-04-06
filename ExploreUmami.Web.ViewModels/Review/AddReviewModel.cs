using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.Review;

namespace ExploreUmami.Web.ViewModels.Review
{
    public class AddReviewModel
    {
        [Required]
        [StringLength(SubjectMaxLength,MinimumLength = SubjectMinLength)]
        public string Subject { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLength,MinimumLength = ContentMinLength)]
        public string Content { get; set; } = null!;

        [Required]
        [Range(MinRating, MaxRating)]
        public double Rating { get; set; }
    }
}
