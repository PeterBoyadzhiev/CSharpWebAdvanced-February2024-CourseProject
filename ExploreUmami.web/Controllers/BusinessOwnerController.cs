using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.BusinessOwner;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static ExploreUmami.Common.NotificationMessagesConstants;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class BusinessOwnerController : Controller
    {
        private readonly IBusinessOwnerService businessOwnerService;

        public BusinessOwnerController(IBusinessOwnerService businessOwnerService)
        {
            this.businessOwnerService = businessOwnerService;
        }

        [HttpGet]
        public async Task<IActionResult> Switch()
        {
            string userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

            if (isOwner)
            {
                TempData[ErrorMessage] = "You are already a business owner!";
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Switch(SwitchFormModel model)
        {
            string userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

            if (isOwner)
            {
                TempData[ErrorMessage] = "You are already a business owner!";
                return RedirectToAction("Index", "Home");
            }

            try
            {
                await this.businessOwnerService.AddOwnerAsync(userId, model);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "An error occurred while registering you as a business owner. Please try again later or contact administrator.";
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("MyBusinesses", "Business");
        }
    }
}
