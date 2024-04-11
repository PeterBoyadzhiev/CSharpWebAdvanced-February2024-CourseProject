using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Review;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Areas.Admin.Controllers
{
    public class ReviewController : BaseAdminController
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<ReviewInfoAdminModel> reviews = await this.reviewService.GetAllReviewsAsync();

            return View(reviews);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int id)
        {
            await this.reviewService.RemoveReviewAsync(id);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Allow(int id)
        {
            await this.reviewService.AllowReviewAsync(id);

            return RedirectToAction(nameof(All));
        }
    }
}
