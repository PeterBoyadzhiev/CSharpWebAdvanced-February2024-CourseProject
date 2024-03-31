using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static ExploreUmami.Common.NotificationMessagesConstants;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class BusinessController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IPrefectureService prefectureService;
        private readonly IBusinessOwnerService businessOwnerService;
        private readonly IBusinessService businessService;

        public BusinessController
            (ICategoryService categoryService,
            IPrefectureService prefectureService,
            IBusinessOwnerService businessOwnerService,
            IBusinessService businessService)
        {
            this.categoryService = categoryService;
            this.prefectureService = prefectureService;
            this.businessOwnerService = businessOwnerService;
            this.businessService = businessService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllBusinessFilterModel filterModel)
        {
            FilterAndPageModel serviceModel = await this.businessService
                .GetBusinessFilteredAsync(filterModel);

            filterModel.Categories = await this.categoryService.AllCategoryNamesAsync();
            filterModel.Prefectures = await this.prefectureService.AllPrefectureNamesAsync();
            filterModel.Businesses = serviceModel.Businesses;
            filterModel.TotalBusinesses = serviceModel.TotalBusinessesCount;

            return View(filterModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner)
            {
                this.TempData["Error"] = "You must be a business owner to add a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            BusinessFormModel model = new BusinessFormModel
            {
                Categories = await this.categoryService.GetAllCategoriesAsync(),
                Prefectures = await this.prefectureService.GetAllPrefecturesAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BusinessFormModel model)
        {
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner)
            {
                this.TempData["Error"] = "You must be a business owner to add a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            bool categoryExists = await this.categoryService.CategoryExistsByIdAsync(model.CategoryId);
            bool prefectureExists = await this.prefectureService.PrefectureExistsByIdAsync(model.PrefectureId);

            if (!categoryExists)
            {
                ModelState.AddModelError(nameof(model.CategoryId),"Category does not exist");

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }

            if (!prefectureExists)
            {
                ModelState.AddModelError(nameof(model.PrefectureId), "Prefecture does not exist");

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }

            try
            {
                string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(this.User.GetId()!);

                await this.businessService.AddBusinessAsync(model, ownerId!);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurred while adding business");

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }  

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> MyBusinesses()
        {
            List<BusinessAllViewModel> businesses = new List<BusinessAllViewModel>();

            string? userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

            if (isOwner)
            {
                string? agentId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(userId);
                businesses.AddRange(await this.businessService.AllBusinessesByOwnerIdAsync(agentId!));
            }
            else
            {
                businesses.AddRange(await this.businessService.AllBusinessesByReviewerIdAsync(userId));
            }

            return View(businesses);

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(id);

            if (!businessExists)
            {
                this.TempData["Error"] = "Business does not exist!";
                return this.RedirectToAction("All", "Business");
            }

            BusinessDetailsViewModel model = await this.businessService.GetBusinessDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {

            bool businessExists = await this.businessService.ExistsByIdAsync(id);

            if (!businessExists)
            {
                this.TempData["Error"] = "Business does not exist!";
                return this.RedirectToAction("All", "Business");
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner)
            {
                this.TempData["Error"] = "You must be a business owner to edit a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(this.User.GetId()!);

            bool isUserOwner = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(ownerId!, id);

            if (!isUserOwner)
            {
                this.TempData["Error"] = "You must be the owner of the business to edit!";

                return RedirectToAction("MyBusinesses", "Business");

            }

            BusinessFormModel model = await this.businessService.GetBusinessToEditAsync(id);

            model.Categories = await this.categoryService.GetAllCategoriesAsync();
            model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

            return View(model);
        }

        public IActionResult BusinessPerCountry() 
        { 
            return View(); 
        }
    }
}
