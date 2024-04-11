using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;
using Microsoft.AspNetCore.Mvc;

using static ExploreUmami.Common.NotificationMessagesConstants;

namespace ExploreUmami.Web.Areas.Admin.Controllers
{
    public class BusinessController : BaseAdminController
    {
        private readonly IBusinessService businessService;
        private readonly ICategoryService categoryService;
        private readonly IPrefectureService prefectureService;

        public BusinessController(IBusinessService businessService,
            ICategoryService categoryService,
            IPrefectureService prefectureService)
        {
            this.businessService = businessService;
            this.categoryService = categoryService;
            this.prefectureService = prefectureService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] BusinessAllFilterModel filterModel)
        {
            BusinessFilterAndPageModel serviceModel = await this.businessService
                .GetBusinessFilteredForAdminAsync(filterModel);

            filterModel.Categories = await this.categoryService.AllCategoryNamesAsync();
            filterModel.Prefectures = await this.prefectureService.AllPrefectureNamesAsync();
            filterModel.Businesses = serviceModel.Businesses;
            filterModel.TotalBusinesses = serviceModel.TotalBusinessesCount;

            return View(filterModel);
        }

        [HttpGet]
        public async Task<IActionResult> ForApproval()
        {
            IEnumerable<BusinessAllViewModel> businesses = await this.businessService
                .GetBusinessesForApprovalAsync();

            return View(businesses);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(string id)
        {
            try
            {
                await this.businessService.ApproveBusinessAsync(id);

                TempData["Success"] = "Business approved successfully.";
                return RedirectToAction(nameof(ForApproval));
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while editing business.";

                return RedirectToAction(nameof(All));
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Reinstate(string id)
        {
            try
            {
                await this.businessService.ReinstateBusinessAsync(id);

                TempData["Success"] = "Business reinstated successfully.";
                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while editing business.";

                return RedirectToAction(nameof(All));
            }
        }
    }
}
