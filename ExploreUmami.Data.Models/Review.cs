using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ExploreUmami.Common.ValidationConstants.Review;

namespace ExploreUmami.Data.Models 

{
    public class Review
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        [ForeignKey(nameof(Business))]
        public Guid BusinessId { get; set; }

        public Business Business { get; set; } = null!;

        [ForeignKey(nameof(Reviewer))]
        public Guid? ReviewerId { get; set; }

        public virtual ApplicationUser? Reviewer { get; set; }
    }
}