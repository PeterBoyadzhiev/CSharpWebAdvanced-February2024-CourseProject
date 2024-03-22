using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ExploreUmami.Common.ValidationConstants.BusinessOwner;

namespace ExploreUmami.Data.Models
{
    public class BusinessOwner
    {

        public BusinessOwner()
        {
            Id = Guid.NewGuid();
            OwnedBusinesses = new HashSet<Business>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        [RegularExpression(PhoneNumberRegularExpression)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(NameOfBusinessMaxLength)]
        public string NameOfBusiness { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        public ICollection<Business> OwnedBusinesses { get; set; } = null!;
    }
}