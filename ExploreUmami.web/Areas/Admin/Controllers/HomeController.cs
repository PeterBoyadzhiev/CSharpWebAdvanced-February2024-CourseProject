using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.Areas.Admin.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Business;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        private readonly IBusinessService businessService;

        public HomeController(IBusinessService businessService)
        {
            this.businessService = businessService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<BusinessAllViewModel> lastThreeBusinesses = await this.businessService.GetLastThreeBusinessesForApprovalAsync();
            IndexViewModel model = new IndexViewModel
            {
                BusinessesToApprove = lastThreeBusinesses,
            };

            return View(model);
        }
    }
}
