using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.BusinessOwner;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class BusinessOwnerServiceTests : UnitTestsBase
    {
        private IBusinessOwnerService _businessOwnerService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _data.Database.EnsureCreated();
            _businessOwnerService = new BusinessOwnerService(_data);
        }

        [Test]
        public async Task IsOwnerByUserIdAsync_ShouldReturnTrue_IfOwner()
        {
            string existingBusinessOwnerId = BusinessOwnerUser.Id.ToString();
            bool result = await this._businessOwnerService.IsOwnerByUserIdAsync(existingBusinessOwnerId);
            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsOwnerByUserIdAsync_ShouldReturnFalse_IfNotOwner()
        {
            string nonBusinessOwnerId = User2.Id.ToString();
            bool result = await this._businessOwnerService.IsOwnerByUserIdAsync(nonBusinessOwnerId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task IsOwnerByUserIdAsync_ShouldReturnsFalse_IfWrongId()
        {
            string userId = "C789E697-C4CC-44BE-B033-44B4BC561E67"; // Non-existing user id
            bool result = await this._businessOwnerService.IsOwnerByUserIdAsync(userId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task AddOwnerAsync_ShouldCreateBusinessOwner_WhenValidDataProvided()
        {
            string userId = User.Id.ToString();
            var businessOwnerService = new BusinessOwnerService(_data); // Create new instance per test

            var testModel = new SwitchFormModel { NameOfBusiness = "Test Business", PhoneNumber = "123-456-7890" };

            int expectedCount = 2; // Initial count is 1, so this should be 2 after adding a new owner

            await businessOwnerService.AddOwnerAsync(userId, testModel);

            // Verify data is added to the database (without relying on mocking)
            int businessOwnerCount = this._data.BusinessOwners.Count();
            Assert.That(expectedCount, Is.EqualTo(businessOwnerCount));

            // You can optionally verify specific properties of the added BusinessOwner object
            // using LINQ or other methods to retrieve it from the DbContext.
        }

        [Test]
        public async Task GetOwnerIdByUserIdAsync_ShouldReturnOwnerId_WhenOwnerExists()
        {
            string userId = BusinessOwnerUser.Id.ToString();
            string? ownerId = await this._businessOwnerService.GetOwnerIdByUserIdAsync(userId);
            Assert.That(BusinessOwner.Id.ToString(), Is.EqualTo(ownerId)); // BusinessOwner.Id is an auto-generated Guid
        }
    }
}
