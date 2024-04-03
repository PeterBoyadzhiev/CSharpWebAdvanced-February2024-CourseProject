using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Reservation;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Reservation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;
        private readonly IBusinessOwnerService businessOwnerService;
        private readonly IBusinessService businessService;

        public ReservationController(IReservationService reservationService,
            IBusinessOwnerService businessOwnerService,
            IBusinessService businessService)
        {
            this.reservationService = reservationService;
            this.businessOwnerService = businessOwnerService;
            this.businessService = businessService;
        }

        //[HttpGet]
        //public async Task<IActionResult> All([FromQuery] ReservationAllUserFilterModel filterModel)
        //{
        //    List<ReservationDetailsViewModel> reservations = new List<ReservationDetailsViewModel>();

        //    string? userId = this.User.GetId();
        //    bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

        //    try
        //    {
        //        if (isOwner)
        //        {
        //            string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(userId);
        //            reservations.AddRange(await this.reservationService.AllReservationsByOwnerIdAsync(ownerId!));
        //        }
        //        else
        //        {
        //            reservations.AddRange(await this.reservationService.AllReservationsByUserIdAsync(userId));
        //        }

        //        return View(reservations);
        //    }
        //    catch (Exception)
        //    {
        //        this.TempData["Error"] = "Unexpected error occurred!";
        //        return RedirectToAction("Index", "Home");
        //    }
        //}

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] ReservationFilterViewModel filterModel)
        {
            string? userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);
            ReservationFilterAndPageModel serviceModel = new ReservationFilterAndPageModel();

            if (isOwner)
            {
                string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(userId);
                serviceModel = await this.reservationService.GetReservationsByFilterForOwnerAsync(filterModel, ownerId!);
            }
            else
            {
                serviceModel = await this.reservationService.GetReservationsByFilterForUserAsync(filterModel, userId);
            }

            filterModel.Reservations = serviceModel.Reservations;
            filterModel.TotalReservations = serviceModel.TotalReservationsCount;

            return View(filterModel);
        }
    }
}
