﻿using ExploreUmami.Data.Models;
using ExploreUmami.Data.Models.Enums;
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
        private readonly IUserVisitService userVisitService;

        public ReservationController(IReservationService reservationService,
            IBusinessOwnerService businessOwnerService,
            IBusinessService businessService,
            ICategoryService categoryService,
            IPrefectureService prefectureService,
            IUserVisitService userVisitService)
        {
            this.reservationService = reservationService;
            this.businessOwnerService = businessOwnerService;
            this.businessService = businessService;
            this.categoryService = categoryService;
            this.prefectureService = prefectureService;
            this.userVisitService = userVisitService;
        }


        [HttpGet]
        public async Task<IActionResult> All([FromQuery] ReservationFilterViewModel filterModel)
        {
            string? userId = this.User.GetId();
            bool isOwner = await this.businessOwnerService.IsOwnerByUserIdAsync(userId);
            ReservationFilterAndPageModel serviceModel;

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
        public async Task<IActionResult> Make(string id)
        {
            bool businessExists = await this.businessService.ExistsByIdAsync(id);

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
                this.TempData["Error"] = "Unexpected error occurred!";
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
                this.TempData["Error"] = "Unexpected error occurred!";
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
                    string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(currentUserId);
                    bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(ownerId!, businessId);

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
                TempData["Error"] = "Unexpected error occurred!";
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
                    string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(currentUserId);
                    bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(ownerId!, businessId);

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
                TempData["Error"] = "Unexpected error occurred!";
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
                        string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(currentUserId);
                        bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(ownerId!, businessId);

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
                TempData["Error"] = "Unexpected error occurred!";
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
                    string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(currentUserId);
                    bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(ownerId!, businessId);

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
                TempData["Error"] = "Unexpected error occurred!";
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
                        string? ownerId = await this.businessOwnerService.GetOwnerIdByUserIdAsync(currentUserId);
                        bool isOwnerOfBusiness = await this.businessService.IsUserOwnerOfBusinessByIdsAsync(ownerId!, businessId);

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
                TempData["Error"] = "Unexpected error occurred!";
                return RedirectToAction("All", "Reservation");
            }
        }

    }
}