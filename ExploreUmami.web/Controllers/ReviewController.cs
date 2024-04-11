using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;
        private readonly IBusinessOwnerService businessOwnerService;
        private readonly IUserVisitService userVisitService;

        public ReviewController(IBusinessOwnerService businessOwnerService, IReviewService reviewService, IUserVisitService userVisitService)
        {
            this.businessOwnerService = businessOwnerService;
            this.reviewService = reviewService;
            this.userVisitService = userVisitService;

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isOwner = await businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (isOwner)
            {
                this.TempData["Error"] = "You are a business owner and cannot add reviews.";
                return RedirectToAction("MyBusinesses", "Business");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddReviewModel model, string id)
        {
            // Check for existing review for business and user
            string? userId = this.User.GetId();
            bool hasVisited = await userVisitService.UserHasVisitAsync(userId, id);

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            bool isOwner = await businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (isOwner)
            {
                this.TempData["Error"] = "You are a business owner and cannot add reviews.";
                return RedirectToAction("MyBusinesses", "Business");
            }

            bool reviewExists = await reviewService.ReviewExistsByUserForBusinessAsync(userId, id);

            try
            {
                if (reviewExists)
                {
                    this.TempData["Error"] = "You have already added a review for this business.";
                    return RedirectToAction("Visited", "UserVisit");
                }

                string? userLocation = null;

                if (Request.Cookies["location"] != null)
                {
                    userLocation = Uri.UnescapeDataString(Request.Cookies["location"] ?? "");
                }

                if (hasVisited)
                {
                    await reviewService.AddReviewAsync(model, id, userId, userLocation);

                    this.TempData["Success"] = "Review added successfully!";
                    return RedirectToAction("Visited", "UserVisit");
                }
                
                else
                {
                    this.TempData["Error"] = "You have not visited this business and cannot add a review.";
                    return RedirectToAction("Visited", "UserVisit");
                }
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Business");
            }
        }
    }
}
