using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.BusinessOwner
{
    public class OwnerInfoModel
    {
        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;


    }
}
