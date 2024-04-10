namespace ExploreUmami.Web.ViewModels.Business
{
    public class BusinessAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public bool isActive { get; set; }

        public bool IsApproved { get; set; }

    }

}
