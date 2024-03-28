using ExploreUmami.Web.ViewModels.Category;
using ExploreUmami.Web.ViewModels.Prefectures;
using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.Business;

namespace ExploreUmami.Web.ViewModels.Business
{
    public class AddBusinessFormModel
    {
        public AddBusinessFormModel()
        {
            Categories = new HashSet<SelectCategoryFormModel>();
            Prefectures = new HashSet<SelectPrefectureFormModel>();
        }

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [RegularExpression(PhoneNumberRegularExpression)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(WebsiteURLsiteMaxLength, MinimumLength = WebsiteURLMinLength)]
        [Display(Name = "Website Link")]
        public string? WebsiteURL { get; set; }

        [Required]
        [StringLength(ImageURLMaxLength, MinimumLength = ImageURLMinLength, ErrorMessage = "Image is not the correct size")]
        [Display(Name = "Image Link")]
        public string ImageURL { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Prefecture")]
        public int PrefectureId { get; set; }

        public IEnumerable<SelectCategoryFormModel> Categories { get; set; }

        public IEnumerable<SelectPrefectureFormModel> Prefectures { get; set; }

    }
}
