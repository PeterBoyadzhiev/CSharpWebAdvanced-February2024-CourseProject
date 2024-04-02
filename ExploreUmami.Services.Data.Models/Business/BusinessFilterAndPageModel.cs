using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Services.Data.Models.Business
{
    public class BusinessFilterAndPageModel
    {
        public BusinessFilterAndPageModel()
        {
            this.Businesses = new HashSet<BusinessAllViewModel>();
        }

        public int TotalBusinessesCount { get; set; }

        public IEnumerable<BusinessAllViewModel> Businesses { get; set; }
    }
}
