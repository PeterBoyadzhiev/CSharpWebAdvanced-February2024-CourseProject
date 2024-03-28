
namespace ExploreUmami.Web.ViewModels.Business
{
    public class MyBusinessesViewModel
    {
        public MyBusinessesViewModel()
        {
            this.Businesses = new HashSet<BusinessAllViewModel>();
        }

        public IEnumerable<BusinessAllViewModel> Businesses { get; set; }


    }
}
