namespace ExploreUmami.Web.ViewModels.Review
{
    using ExploreUmami.Web.ViewModels.Business;
    using ExploreUmami.Web.ViewModels.User;

    public class ReviewInfoAdminModel
    {
        public int Id { get; set; }

        public string Subject { get; set; } = null!;

        public string Content { get; set; } = null!;

        public double Rating { get; set; }

        public bool IsActive { get; set; }

        public DateTime TimeStamp { get; set; }

        public BusinessDetailsViewModel Business { get; set; } = null!;

        public UserDetailsViewModel Reviewer { get; set; } = null!;
    }
}
