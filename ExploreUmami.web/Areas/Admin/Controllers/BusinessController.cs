using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

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
    }
}
