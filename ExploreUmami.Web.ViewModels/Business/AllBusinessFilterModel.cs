using ExploreUmami.Web.ViewModels.Business.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.Business
{
    public class AllBusinessFilterModel
    {
        public AllBusinessFilterModel()
        {
            this.CurrentPage = 1;
            this.BusinessPerPage = 3;

            this.Categories = new HashSet<string>();
            this.Prefectures = new HashSet<string>();
            this.Businesses = new HashSet<BusinessAllViewModel>();
        }

        public string? Category { get; set; }

        public string? Prefecture { get; set; }

        [Display(Name = "Search")]
        public string? SearchTerm { get; set; }

        [Display(Name = "Sort By")]
        public BusinessSorting BusinessSorting { get; set; }

        public int CurrentPage { get; set; }

        public int BusinessPerPage { get; set; }

        public int TotalBusinesses { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<string> Prefectures { get; set; }

        public IEnumerable<BusinessAllViewModel> Businesses { get; set; }
    }
}
