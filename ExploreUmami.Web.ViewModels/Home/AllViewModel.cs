using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Web.ViewModels.Home
{
    public class AllViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }

        public IEnumerable<BusinessViewModel> Businesses { get; set; } = new List<BusinessViewModel>();
    }

}
