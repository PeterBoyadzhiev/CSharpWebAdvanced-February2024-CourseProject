using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Home;
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

        [AllowAnonymous]

        public async Task<IActionResult> All(int pageNumber = 1, int pageSize = 3)
        {
            string pageNumberString = HttpContext.Request.Query["pageNumber"];
            pageNumber = int.TryParse(pageNumberString, out int parsedPageNumber) ? parsedPageNumber : 1;

            IEnumerable<BusinessViewModel> businesses = await this.businessService.GetBusinessesAsync();

            int totalBusinesses = businesses.Count(); // Get total number of businesses
            int skip = (pageNumber - 1) * pageSize;
            businesses = businesses.Skip(skip).Take(pageSize);

            var viewModel = new AllViewModel
            {
                CurrentPage = pageNumber,
                Businesses = businesses.Select(b => new BusinessViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    ImageURL = b.ImageURL,
                }).ToList(),
                TotalPages = (int)Math.Ceiling((double)totalBusinesses / pageSize)
            };

            return View(viewModel);
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

            AddBusinessFormModel model = new AddBusinessFormModel
            {
                Categories = await this.categoryService.GetAllCategoriesAsync(),
                Prefectures = await this.prefectureService.GetAllPrefecturesAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBusinessFormModel model)
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
                string? ownerId = await this.businessOwnerService.GetOwnerIdByUserId(this.User.GetId()!);

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

        public IActionResult BusinessPerCountry() 
        { 
            return View(); 
        }
    }
}
