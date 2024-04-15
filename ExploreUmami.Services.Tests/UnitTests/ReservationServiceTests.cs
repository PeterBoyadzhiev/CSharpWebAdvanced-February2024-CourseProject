using ExploreUmami.Data.Models;
using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Reservation;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Reservation;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class ReservationServiceTests : UnitTestsBase
    {
        private IReservationService _reservationService;

        [SetUp]
        public void SetUp()
        {
            _reservationService = new ReservationService(_data);
        }

        [Test]
        public async Task MakeReservationAsync_ShouldCreateReservation_WhenValidDataProvided()
        {
            var businessId = Business.Id.ToString();
            var userId = User.Id.ToString();

            var testModel = new MakeReservationFormModel
            {
                ReservationDate = DateTime.UtcNow,
            };

            int expectedCount = _data.Reservations.Count() + 1;

            await _reservationService.MakeReservationAsync(testModel, userId, businessId);

            Assert.That(_data.Reservations.Count(), Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task UserHasIncompleteReservationAsync_ShouldReturnTrue_IfUserHasIncompleteReservation()
        {
            var userId = User.Id.ToString();
            var businessId = Business.Id.ToString();

            var testModel = new MakeReservationFormModel
            {
                ReservationDate = DateTime.UtcNow,
            };

            await _reservationService.MakeReservationAsync(testModel, userId, businessId);

            var result = await _reservationService.UserHasIncompleteReservationAsync(userId,businessId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task UserHasIncompleteReservationAsync_ShouldReturnFalse_IfUserDoesNotHaveIncompleteReservation()
        {
            var userId = User.Id.ToString();
            var businessId = Business.Id.ToString();

            var result = await _reservationService.UserHasIncompleteReservationAsync(userId, businessId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task ChangeReservationStatusByIdAsync_ShouldChangeReservationStatus_WhenValidDataProvided()
        {
            var reservationId = Reservation.Id.ToString();
            var newStatus = ReservationStatus.Completed.ToString();

            await _reservationService.ChangeReservationStatusByIdAsync(reservationId, newStatus);

            var reservation = _data.Reservations.FirstOrDefault(r => r.Id.ToString() == reservationId);

            Assert.That(reservation.Status, Is.EqualTo(ReservationStatus.Completed));
        }

        [Test]
        public async Task ChangeReservationStatusByIdAsyncWithNotes_ShouldChangeReservationStatusAndNotes_WhenValidDataProvided()
        {
            var reservationId = Reservation.Id.ToString();
            var newStatus = ReservationStatus.Completed.ToString();
            var newNotes = "Test notes";

            await _reservationService.ChangeReservationStatusByIdAsync(reservationId, newStatus, newNotes);

            var reservation = _data.Reservations.FirstOrDefault(r => r.Id.ToString() == reservationId);

            Assert.That(reservation.Status, Is.EqualTo(ReservationStatus.Completed));
            Assert.That(reservation.Notes, Is.EqualTo(newNotes));
        }

        [Test]
        public async Task GetReservationByIdAsync_ShouldReturnReservation_WhenValidIdProvided()
        {
            var reservationId = Reservation.Id.ToString();

            var reservation = await _reservationService.GetReservationByIdAsync(reservationId);

            Assert.That(reservation.Id, Is.EqualTo(Reservation.Id));
        }

        [Test]
        public async Task GetBusinessIdByReservationIdAsync_ShouldReturnBusinessId_WhenValidReservationIdProvided()
        {
            var reservationId = Reservation.Id.ToString();
            var expectedBusinessId = Business.Id.ToString();
            var actualBusinessId = await _reservationService.GetBusinessIdByReservationIdAsync(reservationId);

            Assert.That(actualBusinessId, Is.EqualTo(expectedBusinessId));
        }

        [Test]
        public async Task GetReservationForCancelOrCompleteByIdAsync_ShouldReturnReservation_WhenValidIdProvided()
        {
            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                BusinessId = Business.Id,
                UserId = User.Id,
                ReservationDate = DateTime.UtcNow,
                Status = ReservationStatus.Completed,
            };
            var reservation2 = new Reservation
            {
                Id = Guid.NewGuid(),
                BusinessId = Business.Id,
                UserId = User.Id,
                ReservationDate = DateTime.UtcNow,
                Status = ReservationStatus.Cancelled,
            };

            _data.Reservations.Add(reservation);
            _data.Reservations.Add(reservation2);
            _data.SaveChanges();


            var result1 = await _reservationService.GetReservationForCancelOrCompleteByIdAsync(reservation.Id.ToString());
            var result2 = await _reservationService.GetReservationForCancelOrCompleteByIdAsync(reservation2.Id.ToString());

            Assert.That(result1.Id, Is.EqualTo(reservation.Id));
            Assert.That(result2.Id, Is.EqualTo(reservation2.Id));
        }

    }
}
