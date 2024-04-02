using ExploreUmami.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService; // Assuming an interface for reservation logic

        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        public async Task<IActionResult> All()
        {
            var allReservations = await reservationService.GetReservationsAsync();
            return View(allReservations);
        }
    }
}
