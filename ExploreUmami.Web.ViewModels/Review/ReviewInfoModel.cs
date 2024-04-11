namespace ExploreUmami.Web.ViewModels.Review
{
    public class ReviewInfoModel
    {
        public string Subject { get; set; } = null!;

        public string Content { get; set; } = null!;

        public double Rating { get; set; }

        public DateTime TimeStamp { get; set; }

        public string? UserLocation { get; set; }

        public string Reviewer { get; set; } = null!;
    }
}
