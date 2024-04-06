using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Review;
using ExploreUmami.Web.ViewModels.User;

namespace ExploreUmami.Web.ViewModels.UserVisit
{
    public class UserVisitDetailsViewModel
    {
        public string Id { get; set; } = null!;

        public DateTime VisitDate { get; set; }

        public string? Notes { get; set; }

        public BusinessDetailsViewModel Business { get; set; } = null!;

        public UserDetailsViewModel User { get; set; } = null!;

        public VisitsReviewViewModel Review { get; set; } = null!;

        public bool HasReview { get; set; }
    }
}
