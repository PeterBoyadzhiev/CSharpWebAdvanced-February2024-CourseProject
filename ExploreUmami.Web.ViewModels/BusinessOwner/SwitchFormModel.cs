using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.BusinessOwner;

namespace ExploreUmami.Web.ViewModels.BusinessOwner
{
    public class SwitchFormModel
    {
        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [Phone]
        [RegularExpression(PhoneNumberRegularExpression, ErrorMessage = PhoneNumberErrorMessage)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(NameOfBusinessMaxLength, MinimumLength = NameOfBusinessMinLength)]
        [Display(Name = "Name of Main Business")]
        public string NameOfBusiness { get; set; } = null!;
    }
}
