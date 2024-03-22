using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.BusinessOwner;

namespace ExploreUmami.Web.ViewModels.Home
{
    public class SwitchFormModel
    {
        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(NameOfBusinessMaxLength, MinimumLength = NameOfBusinessMinLength)]
        public string NameOfBusiness { get; set; } = null!;
    }
}
