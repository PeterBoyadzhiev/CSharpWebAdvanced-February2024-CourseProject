using ExploreUmami.Web.ViewModels.BusinessOwner;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Web.ViewModels.Business
{
    public class BusinessDetailsViewModel : BusinessAllViewModel
    {
        public string Address { get; set; } = null!;

        [Display(Name = "Business Number")]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Website Link")]
        public string WebsiteUrl { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Prefecture { get; set; } = null!;

        public OwnerInfoModel Owner { get; set; } = null!;
    }
}
