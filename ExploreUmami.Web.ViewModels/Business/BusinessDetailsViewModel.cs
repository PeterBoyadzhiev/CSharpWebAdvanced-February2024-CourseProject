using ExploreUmami.Web.ViewModels.BusinessOwner;
using ExploreUmami.Web.ViewModels.Review;
using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.Business
{
    public class BusinessDetailsViewModel : BusinessAllViewModel
    {
        public BusinessDetailsViewModel()
        {
            Reviews = new HashSet<ReviewInfoModel>();
        }

        public string Address { get; set; } = null!;

        [Display(Name = "Business Number")]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Website Link")]
        public string WebsiteUrl { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Prefecture { get; set; } = null!;

        public double AverageRating { get; set; }

        public OwnerInfoModel Owner { get; set; } = null!;

        public ICollection<ReviewInfoModel> Reviews { get; set; }
    }
}
