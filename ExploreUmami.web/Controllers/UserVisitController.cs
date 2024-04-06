using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.UserVisit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class UserVisitController : Controller
    {
        private readonly IUserVisitService userVisitService;
        private readonly IBusinessOwnerService businessOwnerService;
        private readonly IBusinessService businessService;
        private readonly IReviewService reviewService;

        public UserVisitController(IUserVisitService userVisitService,
                                    IBusinessOwnerService businessOwnerService,
                                    IBusinessService businessService,
                                    IReviewService reviewService)
        {
            this.userVisitService = userVisitService;
            this.businessOwnerService = businessOwnerService;
            this.businessService = businessService;
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> Visited()
        {
            try
            {
                string? userId = this.User.GetId();

                IEnumerable<UserVisitDetailsViewModel> model = await this.userVisitService.GetUserVisitsAsync(userId);

                bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

                if (isOwner)
                {
                    TempData["Error"] = "You are a business owner and do not have visited businesses.";
                    return RedirectToAction("MyBusinesses", "Business");
                }

                return this.View(model);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("Index", "Home");
            }
            
            
        }

        [HttpGet]
        public async Task<IActionResult> Visits()
        {
            try
            {
                string? userId = this.User.GetId();
                string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(userId);
                bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);


                IEnumerable<UserVisitDetailsViewModel> model = await this.userVisitService.GetBusinessVisitsPerOwnerAsync(ownerId!);


                if (!isOwner)
                {
                    TempData["Error"] = "You are not a business owner!";
                    return RedirectToAction("Switch", "BusinessOwner");
                }

                return this.View(model);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("Index", "Home");
            }
            

            
        }
    }
}
