using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.Infrastructure.Extensions;
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
            bool isOwner = await this.businessOwnerService.IsOwnerByUserId(userId);

            if (isOwner)
            {
                TempData[ErrorMessage] = "You are already a business owner!";
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
