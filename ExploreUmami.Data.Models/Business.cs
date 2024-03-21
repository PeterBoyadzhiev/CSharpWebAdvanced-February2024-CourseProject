using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ExploreUmami.Common.ValidationConstants.Business;

namespace ExploreUmami.Data.Models
{
    public class Business
    {
        public Business()
        {
            Id = Guid.NewGuid();
            Reviews = new HashSet<Review>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [MaxLength(WebsiteURLsiteMaxLength)]
        public string? WebsiteURL { get; set; }

        [Required]
        [MaxLength(ImageURLMaxLength)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Prefecture))]
        public int PrefectureId { get; set; }

        public Prefecture Prefecture { get; set; }

        [ForeignKey(nameof(BusinessOwner))]
        public Guid BusinessOwnerId { get; set; }

        public BusinessOwner BusinessOwner { get; set; } = null!;

        [ForeignKey(nameof(Visitor))]
        public Guid? VisitorId { get; set; }

        public virtual ApplicationUser? Visitor { get; set; } = null!;

        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}