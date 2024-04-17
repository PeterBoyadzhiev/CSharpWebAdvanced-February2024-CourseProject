using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Reservation;
using ExploreUmami.Web.Infrastructure.Extensions;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Reservation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static ExploreUmami.Common.AppConstantsGeneral;
using static ExploreUmami.Common.ValidationConstants.ErrorMessages;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;
        private readonly IBusinessOwnerService businessOwnerService;
        private readonly IBusinessService businessService;
        private readonly IUserVisitService userVisitService;

        public ReservationController(IReservationService reservationService,
            IBusinessOwnerService businessOwnerService,
            IBusinessService businessService,
            IUserVisitService userVisitService)
        {
            this.reservationService = reservationService;
            this.businessOwnerService = businessOwnerService;
            this.businessService = businessService;
            this.userVisitService = userVisitService;
        }


        [HttpGet]
        public async Task<IActionResult> All([FromQuery] ReservationFilterViewModel filterModel)
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }

            string? userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);
            ReservationFilterAndPageModel serviceModel;

            try
            {
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
            catch (Exception)
            {
                this.TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("Index", "Home");
            }

            
        }

        [HttpGet]
        public async Task<IActionResult> Make(string id)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(id);

            if (!businessExists)
            {
                this.TempData["Error"] = BusinessDoesNotExistError;
                return this.RedirectToAction("All", "Business");
            }

            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(this.User.GetId());

            if (isOwner)
            {
                this.TempData["Error"] = "You cannot make a reservation for your own business!";
                return RedirectToAction("All", "Reservation");
            }

            bool isAdmin = this.User.IsInRole(AdminRoleName);

            if (isAdmin)
            {
                this.TempData["Error"] = "You cannot make a reservation as an administrator!";
                return RedirectToAction("All", "Reservation");
            }

            try
            {
                BusinessDetailsReservationViewModel businessModel = await this.businessService.GetBusinessDetailsForReservationAsync(id);

                MakeReservationFormModel reservationModel = new MakeReservationFormModel
                {
                    Business = businessModel,
                };

                ViewData["BusinessName"] = businessModel.Title;

                return View(reservationModel);
            }
            catch (Exception)
            {
                this.TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Make(MakeReservationFormModel model, string id)
        {
            model.Business = await this.businessService.GetBusinessDetailsForReservationAsync(id);

            if (model.ReservationDate < DateTime.Today.AddDays(1))
            {
                TempData["Error"] = "Reservations must be made at least one day in advance.";
                model.Business = await this.businessService.GetBusinessDetailsForReservationAsync(id);
                ViewData["BusinessName"] = model.Business.Title;
                return View(model);
            }

            if (!ModelState.IsValid)
            {

                model.Business = await this.businessService.GetBusinessDetailsForReservationAsync(id);
                ViewData["BusinessName"] = model.Business.Title;
                return View(model);
            }

            try
            {
                bool businessExists = await this.businessService.ExistsByIdAsync(id);

                if (!businessExists)
                {
                    this.TempData["Error"] = BusinessDoesNotExistError;
                    return this.RedirectToAction("All", "Business");
                }

                string userId = this.User.GetId();
                bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);

                if (isOwner)
                {
                    this.TempData["Error"] = "You cannot make a reservation for your own business!";
                    return RedirectToAction("All", "Reservation");
                }

                bool hasIncompleteReservation = await this.reservationService.UserHasIncompleteReservationAsync(userId, id);

                if (hasIncompleteReservation)
                {
                    this.TempData["Error"] = "You already have an outstanding reservation for this business!";
                    return RedirectToAction("All", "Reservation");
                }

                await this.reservationService.MakeReservationAsync(model, userId, id);

                this.TempData["Success"] = "Reservation made successfully!";
                return RedirectToAction("All", "Reservation");
            }
            catch (Exception)
            {
                this.TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatus(string reservationId, string status)
        {
            if (string.IsNullOrEmpty(reservationId))
            {
                TempData["Error"] = "Reservation not found!";
                return RedirectToAction("All", "Reservation");
            }
            if (status != ReservationStatus.Pending.ToString() &&
                status != ReservationStatus.Confirmed.ToString() &&
                status != ReservationStatus.Completed.ToString() &&
                status != ReservationStatus.Cancelled.ToString())
            {
                TempData["Error"] = "Invalid reservation status provided.";
                return RedirectToAction("All", "Reservation");
            }

            try
            {
                string currentUserId = this.User.GetId();
                bool isBusinessOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(currentUserId);

                ReservationDetailsViewModel reservation = await this.reservationService.GetReservationByIdAsync(reservationId);

                string businessId = await this.reservationService.GetBusinessIdByReservationIdAsync(reservationId);

                
                if (isBusinessOwner)
                {
                    bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), businessId);

                    if (!isOwnerOfBusiness)
                    {
                        TempData["Error"] = "You are not authorized to change the reservation status of this reservation.";
                        return RedirectToAction("All", "Reservation");
                    }                    

                    if (Enum.TryParse(status, out ReservationStatus newStatus))
                    {
                        if (status == ReservationStatus.Cancelled.ToString())
                        {
                            return RedirectToAction("Cancel", "Reservation", new { reservationId });
                        }

                        if (status == ReservationStatus.Completed.ToString())
                        {
                            return RedirectToAction("Complete", "Reservation", new { reservationId });
                        }

                        await this.reservationService.ChangeReservationStatusByIdAsync(reservationId, status);
                    }
                    else
                    {
                        TempData["Error"] = "Invalid reservation status provided.";
                        return RedirectToAction("All", "Reservation");
                    }
                }
                else
                {
                    if (status == ReservationStatus.Cancelled.ToString())
                    {
                        return RedirectToAction("Cancel", "Reservation", new { reservationId });
                    }
                    else
                    {
                        TempData["Error"] = "You are not authorized to change the reservation to this status.";
                        return RedirectToAction("All", "Reservation");
                    }
                }

                TempData["Success"] = "Reservation status changed successfully!";
                return RedirectToAction("All", "Reservation");
            }
            catch (Exception)
            {
                TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }


        [HttpGet]
        public async Task<IActionResult> Cancel(string reservationId)
        {
            try
            {
                if (string.IsNullOrEmpty(reservationId))
                {
                    TempData["Error"] = "Reservation not found!";
                    return RedirectToAction("All", "Reservation");
                }

                string currentUserId = this.User.GetId();
                bool isBusinessOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(currentUserId);

                ReservationCompleteOrCancelViewModel reservation = await this.reservationService.GetReservationForCancelOrCompleteByIdAsync(reservationId);

                string businessId = await this.reservationService.GetBusinessIdByReservationIdAsync(reservationId);

                if (isBusinessOwner)
                {
                    bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), businessId);

                    if (!isOwnerOfBusiness)
                    {
                        TempData["Error"] = "You are not authorized to cancel this reservation.";
                        return RedirectToAction("All", "Reservation");
                    }
                }

                return View(reservation);
            }
            catch (Exception)
            {
                TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Cancel(ReservationCompleteOrCancelViewModel model, string reservationId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (string.IsNullOrEmpty(reservationId))
                {
                    TempData["Error"] = "Reservation not found!";
                    return RedirectToAction("All", "Reservation");
                }

                if (model.Answer)
                {
                    string currentUserId = this.User.GetId();
                    bool isBusinessOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(currentUserId);

                    ReservationDetailsViewModel reservation = await this.reservationService.GetReservationByIdAsync(reservationId);

                    string businessId = await this.reservationService.GetBusinessIdByReservationIdAsync(reservationId);

                    if (isBusinessOwner)
                    {
                        bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), businessId);

                        if (!isOwnerOfBusiness)
                        {
                            TempData["Error"] = "You are not authorized to cancel this reservation.";
                            return RedirectToAction("All", "Reservation");
                        }
                    }

                    await this.reservationService.ChangeReservationStatusByIdAsync(reservationId, ReservationStatus.Cancelled.ToString(), model.Notes ?? "");

                    TempData["Success"] = "Reservation cancelled successfully!";
                    return RedirectToAction("All", "Reservation");
                }
                else
                {
                    return RedirectToAction("All", "Reservation");
                }
                
            }
            catch (Exception)
            {
                TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Complete(string reservationId)
        {
            try
            {
                if (string.IsNullOrEmpty(reservationId))
                {
                    TempData["Error"] = "Reservation not found!";
                    return RedirectToAction("All", "Reservation");
                }

                string currentUserId = this.User.GetId();
                bool isBusinessOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(currentUserId);

                ReservationCompleteOrCancelViewModel reservation = await this.reservationService.GetReservationForCancelOrCompleteByIdAsync(reservationId);

                string businessId = await this.reservationService.GetBusinessIdByReservationIdAsync(reservationId);

                if (isBusinessOwner)
                {
                    bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), businessId);

                    if (!isOwnerOfBusiness)
                    {
                        TempData["Error"] = "You are not authorized to complete this reservation.";
                        return RedirectToAction("All", "Reservation");
                    }

                    return View(reservation);
                }
                else
                {
                    TempData["Error"] = "You are not authorized to complete this reservation.";
                    return RedirectToAction("All", "Reservation");
                }
            }
            catch (Exception)
            {
                TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Complete(ReservationCompleteOrCancelViewModel model, string reservationId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (string.IsNullOrEmpty(reservationId))
                {
                    TempData["Error"] = "Reservation not found!";
                    return RedirectToAction("All", "Reservation");
                }

                if (model.Answer)
                {
                    string currentUserId = this.User.GetId();
                    bool isBusinessOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(currentUserId);

                    ReservationDetailsViewModel reservation = await this.reservationService.GetReservationByIdAsync(reservationId);

                    string businessId = await this.reservationService.GetBusinessIdByReservationIdAsync(reservationId);

                    if (isBusinessOwner)
                    {
                        bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(this.User.GetId(), businessId);

                        if (!isOwnerOfBusiness)
                        {
                            TempData["Error"] = "You are not authorized to complete this reservation.";
                            return RedirectToAction("All", "Reservation");
                        }
                    }

                    await this.reservationService.ChangeReservationStatusByIdAsync(reservationId, ReservationStatus.Completed.ToString(), model.Notes ?? "");
                    await this.userVisitService.AddUserVisitForCompletedReservationAsync(Guid.Parse(reservationId), model.Notes);

                    TempData["Success"] = "Reservation completed successfully!";
                    return RedirectToAction("All", "Reservation");
                }
                else
                {
                    return RedirectToAction("All", "Reservation");
                }

            }
            catch (Exception)
            {
                TempData["Error"] = GeneralErrorMessage;
                return RedirectToAction("All", "Reservation");
            }
        }

    }
}
