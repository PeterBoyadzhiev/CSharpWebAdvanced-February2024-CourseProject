using ExploreUmami.Web.ViewModels.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Services.Data.Models.Business
{
    public class FilterAndPageModel
    {
        public FilterAndPageModel()
        {
            this.Businesses = new HashSet<BusinessAllViewModel>();
        }

        public int TotalBusinessesCount { get; set; }

        public IEnumerable<BusinessAllViewModel> Businesses { get; set; }
    }
}
