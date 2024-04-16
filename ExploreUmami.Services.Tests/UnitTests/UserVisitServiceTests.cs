using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class UserVisitServiceTests : UnitTestsBase
    {
        private IUserVisitService _userVisitService;

        [SetUp]
        public void SetUp()
        {
            _userVisitService = new UserVisitService(_data);
        }

        

        [Test]
        public async Task AddUserVisitForCompletedReservationAsync_ShouldCreateUserVisit_WhenValidDataProvided()
        {
            var reservationId = Reservation.Id;
            var userId = User.Id.ToString();

            int expectedCount = _data.UserVisits.Count() + 1;

            await _userVisitService.AddUserVisitForCompletedReservationAsync(reservationId, userId);

            int actualCount = _data.UserVisits.Count();

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }


        [Test]
        public async Task GetUserVisitsAsync_ShouldReturnAllUserVisits()
        {
            var userId = User.Id.ToString();

            var expectedUserVisits = _data.UserVisits.Where(uv => uv.Id.ToString() == userId).ToList();
            var actualUserVisits = await _userVisitService.GetUserVisitsAsync(userId);

            Assert.That(actualUserVisits.Count(), Is.EqualTo(expectedUserVisits.Count));
        }

        [Test]
        public async Task GetUserVisitsAsync_ShouldReturnEmptyList_IfNoUserVisits()
        {
            var userId = User.Id.ToString();

            var actualUserVisits = await _userVisitService.GetUserVisitsAsync(userId);

            Assert.That(actualUserVisits.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetUserVisitsAsync_ShouldReturnEmptyList_IfWrongUserId()
        {
            var userId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing user id

            var actualUserVisits = await _userVisitService.GetUserVisitsAsync(userId);

            Assert.That(actualUserVisits.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetBusinessVisitsPerOwnerAsync_ShouldReturnAllBusinessVisitsPerOwner()
        {
            var ownerId = BusinessOwnerUser.Id.ToString();

            var expectedBusinessVisits = _data.UserVisits.Where(uv => uv.Business.BusinessOwnerId.ToString() == ownerId).ToList();
            var actualBusinessVisits = await _userVisitService.GetBusinessVisitsPerOwnerAsync(ownerId);

            Assert.That(actualBusinessVisits.Count(), Is.EqualTo(expectedBusinessVisits.Count));
        }

        [Test]
        public async Task GetBusinessVisitsPerOwnerAsync_ShouldReturnEmptyList_IfNoBusinessVisits()
        {
            var ownerId = BusinessOwnerUser.Id.ToString();

            var actualBusinessVisits = await _userVisitService.GetBusinessVisitsPerOwnerAsync(ownerId);

            Assert.That(actualBusinessVisits.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task UserHasVisitAsync_ShouldReturnTrue_IfUserHasVisit()
        {
            var userId = User2.Id.ToString();
            var businessId = Business.Id.ToString();

            var result = await _userVisitService.UserHasVisitAsync(userId, businessId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task UserHasVisitAsync_ShouldReturnFalse_IfUserDoesNotHaveVisit()
        {
            var userId = User.Id.ToString();
            var businessId = Business.Id.ToString();

            var result = await _userVisitService.UserHasVisitAsync(userId, businessId);

            Assert.IsFalse(result);
        }
    }
}
