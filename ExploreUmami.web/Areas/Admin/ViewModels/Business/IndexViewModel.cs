using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Web.Areas.Admin.ViewModels.Business
{
    public class IndexViewModel
    {
        public IEnumerable<BusinessAllViewModel> BusinessesToApprove { get; set; } = null!;
    }
}
