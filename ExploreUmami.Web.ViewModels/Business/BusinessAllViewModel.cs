using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.Business
{
    public class BusinessAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Address { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Image Link")]
        public string ImageURL { get; set; } = null!;

        [Display(Name = "Website Link")]
        public string WebsiteUrl { get; set; } = null!;

    }

}
