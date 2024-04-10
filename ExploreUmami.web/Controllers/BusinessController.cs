using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static ExploreUmami.Common.AppConstantsGeneral;


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
        public async Task<IActionResult> All([FromQuery]BusinessAllFilterModel filterModel)
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("All", "Business", new { Area = AdminAreaName });
            }

            BusinessFilterAndPageModel serviceModel = await this.businessService
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
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner)
            {
                if (this.User.isAdmin())
                {
                    this.TempData["Error"] = "You are an administrator and cannot add a business.";
                    return RedirectToAction("All", "Business");
                }
                else
                {
                    this.TempData["Error"] = "You must be a business owner to add a business!";

                    return RedirectToAction("Switch", "BusinessOwner");
                }   
            }


            try
            {
                BusinessFormModel model = new BusinessFormModel
                {
                    Categories = await this.categoryService.GetAllCategoriesAsync(),
                    Prefectures = await this.prefectureService.GetAllPrefecturesAsync(),
                };

                return View(model);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Business");
            }

            
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
                this.TempData["Error"] = "Category does not exist";

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }

            if (!prefectureExists)
            {
                this.TempData["Error"] = "Prefecture does not exist";

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

                this.TempData["Success"] = "Business added successfully!";
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while adding business";

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }  

            return RedirectToAction(nameof(MyBusinesses));
        }

        [HttpGet]
        public async Task<IActionResult> MyBusinesses()
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }

            List<BusinessAllViewModel> businesses = new List<BusinessAllViewModel>();

            string? userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

            try
            {
                if (isOwner)
                {
                    string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(userId);
                    businesses.AddRange(await this.businessService.AllBusinessesByOwnerIdAsync(ownerId!));
                }
                else if (this.User.isAdmin())
                {
                    TempData["Error"] = "You are an administrator and do not own businesses.";
                    return RedirectToAction("All", "Business");
                }
                else
                {
                    TempData["Error"] = "You must be a business owner to view your businesses! Become a business owner.";
                    return RedirectToAction("Switch", "BusinessOwner");
                }

                return View(businesses);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Business");
            }
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

            try
            {
                BusinessDetailsViewModel model = await this.businessService.GetBusinessDetailsByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Business");
            }

            
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

            if (!isOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be a business owner to edit a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            bool isUserOwner = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), id);

            if (!isUserOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be the owner of the business to edit!";

                return RedirectToAction("MyBusinesses", "Business");

            }

            try
            {
                BusinessFormModel model = await this.businessService.GetBusinessToEditAsync(id);

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while editing business";
                return RedirectToAction("All", "Business");
            }

            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, BusinessFormModel model)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(id);

            if (!businessExists)
            {
                this.TempData["Error"] = "Business does not exist!";
                return this.RedirectToAction("All", "Business");
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be a business owner to edit a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            bool isUserOwner = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), id);

            if (!isUserOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be the owner of the business to edit!";

                return RedirectToAction("All", "Business");

            }

            bool categoryExists = await this.categoryService.CategoryExistsByIdAsync(model.CategoryId);
            bool prefectureExists = await this.prefectureService.PrefectureExistsByIdAsync(model.PrefectureId);

            if (!categoryExists)
            {
                this.TempData["Error"] = "Category does not exist";

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }

            if (!prefectureExists)
            {
                this.TempData["Error"] = "Prefecture does not exist";

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
                await this.businessService.EditBusinessByIdAsync(id, model);
                this.TempData["Success"] = "Business edited successfully!";
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while editing business";

                model.Categories = await this.categoryService.GetAllCategoriesAsync();
                model.Prefectures = await this.prefectureService.GetAllPrefecturesAsync();

                return View(model);
            }

            return RedirectToAction("Details", "Business", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(id);

            if (!businessExists)
            {
                this.TempData["Error"] = "Business does not exist!";
                return this.RedirectToAction("All", "Business");
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be a business owner to delete a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            bool isUserOwner = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), id);

            if (!isUserOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be the owner of the business to delete!";

                return RedirectToAction("MyBusinesses", "Business");

            }

            try
            {
                BusinessDeleteViewModel model = await this.businessService.GetBusinessToDeleteAsync(id);
                return View(model);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while deleting business";
                return RedirectToAction("All", "Business");
            }   
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id, BusinessDeleteViewModel model)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(id);

            if (!businessExists)
            {
                this.TempData["Error"] = "Business does not exist!";
                return this.RedirectToAction("All", "Business");
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (!isOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be a business owner to delete a business!";

                return RedirectToAction("Switch", "BusinessOwner");
            }

            bool isUserOwner = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), id);

            if (!isUserOwner && !this.User.isAdmin())
            {
                this.TempData["Error"] = "You must be the owner of the business to delete!";

                return RedirectToAction("MyBusinesses", "Business");

            }

            try
            {
                await this.businessService.DeleteBusinessByIdAsync(id);
                this.TempData["Success"] = "Business deleted successfully!";
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while deleting business";
                return RedirectToAction("All", "Business");
            }

            return RedirectToAction("MyBusinesses", "Business");
        }

        [AllowAnonymous]
        public async Task<IActionResult> ByPrefecture(string name) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                this.TempData["Error"] = "Invalid Prefecture!";
                return this.RedirectToAction("Index", "Home");
            }

            IEnumerable<BusinessAllViewModel> model = await this.businessService.GetBusinessesPerPrefectureAsync(name);

            ViewData["Prefecture"] = name;

            return this.View(model);
        }
    }
}
