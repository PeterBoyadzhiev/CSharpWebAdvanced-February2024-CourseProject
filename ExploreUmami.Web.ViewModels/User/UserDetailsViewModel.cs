using ExploreUmami.Web.ViewModels.Review;

namespace ExploreUmami.Web.ViewModels.User
{
    public class UserDetailsViewModel
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public virtual ICollection<ReviewInfoModel>? Reviews { get; set; }
    }
}
