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
        private readonly ICategoryService categoryService;
        private readonly IPrefectureService prefectureService;

        public ReservationController(IReservationService reservationService,
            IBusinessOwnerService businessOwnerService,
            IBusinessService businessService,
            ICategoryService categoryService,
            IPrefectureService prefectureService)
        {
            this.reservationService = reservationService;
            this.businessOwnerService = businessOwnerService;
            this.businessService = businessService;
            this.categoryService = categoryService;
            this.prefectureService = prefectureService;
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

        [HttpGet]
        public async Task<IActionResult> Make(string businessId)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(businessId);

            if (!businessExists)
            {
                this.TempData["Error"] = "Business does not exist!";
                return this.RedirectToAction("All", "Business");
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (isOwner)
            {
                this.TempData["Error"] = "You cannot make a reservation for your own business!";
                return RedirectToAction("All", "Reservation");
            }

            try
            {
                BusinessDetailsReservationViewModel businessModel = await this.businessService.GetBusinessDetailsForReservationAsync(businessId);

                MakeReservationFormModel reservationModel = new MakeReservationFormModel
                {
                    Business = businessModel,
                };

                return View(reservationModel);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Reservation");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Make(MakeReservationFormModel model, string businessId)
        {

            if (model.ReservationDate < DateTime.Today.AddDays(1))
            {
                TempData["Error"] = "Reservations must be made at least one day in advance.";
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                bool businessExists = await this.businessService.ExistsByIdAsync(businessId);

                if (!businessExists)
                {
                    this.TempData["Error"] = "Business does not exist!";
                    return this.RedirectToAction("All", "Business");
                }

                string userId = this.User.GetId();
                bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

                if (isOwner)
                {
                    this.TempData["Error"] = "You cannot make a reservation for your own business!";
                    return RedirectToAction("All", "Reservation");
                }

                await this.reservationService.MakeReservationAsync(model, userId, businessId);

                this.TempData["Success"] = "Reservation made successfully!";
                return RedirectToAction("All", "Reservation");
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Reservation");
            }

            
        }
    }
}
