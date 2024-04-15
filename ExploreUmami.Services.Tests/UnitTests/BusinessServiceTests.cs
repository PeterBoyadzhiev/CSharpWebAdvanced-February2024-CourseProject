using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Tests.Mocks;
using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class BusinessServiceTests : UnitTestsBase
    {
        private IBusinessService _businessService;

        [SetUp]
        public void SetUp()
        {
              _businessService = new BusinessService(_data);
        }

        [Test]
        public async Task AddBusinessAsync_ShouldIncreaseCount_WhenValidBusiness()
        {
            var business = new BusinessFormModel
            {
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
            };

            var ownerId = BusinessOwnerUser.Id;

            await _businessService.AddBusinessAsync(business, ownerId.ToString());

            Assert.That(_data.Businesses.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetBusinessFilteredAsync_ShouldReturnFilteredBusinesses_WithSearchTerm()
        {
            var filterModel = new BusinessAllFilterModel
            {
                SearchTerm = "Restaurant",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetBusinessFilteredAsync_ShouldReturnFilteredBusinesses_WithPrefecture()
        {
            var filterModel = new BusinessAllFilterModel
            {
                Prefecture = "Hokkaido",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetBusinessFilteredAsync_ShouldReturnFilteredBusinesses_WithCategory()
        {
            var filterModel = new BusinessAllFilterModel
            {
                Category = "Restaurant",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetBusinessFilteredAsync_ShouldReturnFilteredBusinesses_WithCategoryAndPrefecture()
        {
            var filterModel = new BusinessAllFilterModel
            {
                Category = "Restaurant",
                Prefecture = "Hokkaido",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetBusinessFilteredForAdminAsync_ShouldReturnBusinessesWithTerm_ThatAreInactiveOrUnapproved()
        {
            var filterModel = new BusinessAllFilterModel
            {
                SearchTerm = "place",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredForAdminAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetBusinessFilteredForAdminAsync_ShouldReturnBusinessesWithCategory_ThatAreInactiveOrUnapproved()
        {
            var filterModel = new BusinessAllFilterModel
            {
                Category = "Cafe",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredForAdminAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetBusinessFilteredForAdminAsync_ShouldReturnBusinessesWithPrefecture_ThatAreInactiveOrUnapproved()
        {
            var filterModel = new BusinessAllFilterModel
            {
                Prefecture = "Tokyo",
                CurrentPage = 1,
                BusinessPerPage = 3,
            };

            var result = await _businessService.GetBusinessFilteredForAdminAsync(filterModel);

            Assert.That(result.Businesses.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task AllBusinessesByOwnerIdAsync_ShouldReturnActiveBusinesses_WithValidOwnerId()
        {
            var ownerId = BusinessOwner.Id;

            var result = await _businessService.AllBusinessesByOwnerIdAsync(ownerId.ToString());

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task AllBusinessesByOwnerIdAsync_ShouldReturnCorrectBusinesses_WithValidOwnerId()
        {
            var ownerId = BusinessOwnerUser.Id;
            var businessTitle = Business.Title;

            var result = await _businessService.AllBusinessesByOwnerIdAsync(ownerId.ToString());

            foreach (var business in result)
            {
                Assert.That(business.Title, Is.EqualTo(businessTitle));
            }
        }

        [Test]
        public async Task ExistsByIdAsync_ReturnsTrue_WithValidId()
        {
            var businessId = Business.Id;

            var result = await _businessService.ExistsByIdAsync(businessId.ToString());

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByIdAsync_ReturnsFalse_WithInvalidId()
        {
            var businessId = Guid.NewGuid();

            var result = await _businessService.ExistsByIdAsync(businessId.ToString());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetBusinessToEditAsync_ReturnsCorrectBusiness_WithValidId()
        {
            var businessId = Business.Id;

            var result = await _businessService.GetBusinessToEditAsync(businessId.ToString());

            Assert.That(result.Title, Is.EqualTo(Business.Title));
        }

        [Test]
        public async Task IsUserOwnerOfBusinessByIdsAsync_ReturnsTrue_WithValidIds()
        {
            var userId = BusinessOwnerUser.Id;
            var businessId = Business.Id;

            var result = await _businessService.IsUserOwnerOfBusinessByIdsAsync(userId.ToString(), businessId.ToString());

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task IsUserOwnerOfBusinessByIdsAsync_ThrowsException_WithInvalidIds()
        {
            var userId = Guid.NewGuid();
            var businessId = Guid.NewGuid();

            Assert.ThrowsAsync<InvalidOperationException>(() => _businessService.IsUserOwnerOfBusinessByIdsAsync(userId.ToString(), businessId.ToString()));
        }

        [Test]
        public async Task EditBusinessByIdAsync_UpdatesBusiness_WithValidId()
        {
            Business businessToEdit = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = true,
            };
            _data.Businesses.Add(businessToEdit);
            _data.SaveChanges();

            var businessId = businessToEdit.Id;

            var business = new BusinessFormModel
            {
                Title = "TestEdited",
                Description = "TestEdited",
                Address = "TestEdited",
                PrefectureId = 3,
                CategoryId = 3,
                ImageUrl = "https://www.testedited.com/",
                PhoneNumber = "12-3456-7899",
            };

            await _businessService.EditBusinessByIdAsync(businessId.ToString(), business);

            var result = await _data.Businesses.FindAsync(businessId);

            Assert.That(result?.Title, Is.EqualTo("TestEdited"));
        }

        [Test]
        public async Task GetBusinessToDeleteAsync_ReturnsCorrectBusiness_WithValidId()
        {
            var businessId = Business.Id;

            var result = await _businessService.GetBusinessToDeleteAsync(businessId.ToString());

            Assert.That(result.Title, Is.EqualTo(Business.Title));
        }

        [Test]
        public async Task DeleteBusinessByIdAsync_DeletesBusiness_WithValidId()
        {
            Business businessToDelete = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = true,
            };
            _data.Businesses.Add(businessToDelete);
            _data.SaveChanges();

            var businessId = businessToDelete.Id;

            await _businessService.DeleteBusinessByIdAsync(businessId.ToString());

            await _data.Businesses.FindAsync(businessId);

            Assert.IsFalse(businessToDelete.IsActive);
        }

        [Test]
        public async Task GetBusinessDetailsForReservationAsync_ReturnsCorrectBusiness_WithValidId()
        {
            var businessId = Business.Id;

            var result = await _businessService.GetBusinessDetailsForReservationAsync(businessId.ToString());

            Assert.That(result.Title, Is.EqualTo(Business.Title));
        }

        [Test]
        public async Task GetBusinessesPerPrefectureAsync_ReturnsCorrectBusinesses_WithValidPrefecture()
        {
            var prefecture = Prefecture.Name;

            var result = await _businessService.GetBusinessesPerPrefectureAsync(prefecture);

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetLastThreeBusinessesForApprovalAsync_ReturnsLastThreeBusinesses()
        {
            Business businessToFind = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToFind);
            _data.SaveChanges();

            Business businessToFind2 = new Business
            {
                Id = new Guid(),
                Title = "Test2",
                Description = "Test2",
                Address = "Test2",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToFind2);
            _data.SaveChanges();

            var result = await _businessService.GetLastThreeBusinessesForApprovalAsync();

            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetBusinessesForApprovalAsync_ReturnsAllBusinessesForApproval()
        {
            Business businessToFind = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToFind);
            _data.SaveChanges();

            Business businessToFind2 = new Business
            {
                Id = new Guid(),
                Title = "Test2",
                Description = "Test2",
                Address = "Test2",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test2.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToFind2);
            _data.SaveChanges();

            Business businessToFind3 = new Business
            {
                Id = new Guid(),
                Title = "Test3",
                Description = "Test3",
                Address = "Test3",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test3.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToFind3);
            _data.SaveChanges();

            var result = await _businessService.GetBusinessesForApprovalAsync();

            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task ApproveBusinessByIdAsync_ApprovesBusiness_WithValidId()
        {
            Business businessToApprove = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToApprove);
            _data.SaveChanges();

            var businessId = businessToApprove.Id;

            await _businessService.ApproveBusinessAsync(businessId.ToString());

            var result = await _data.Businesses.FindAsync(businessId);

            Assert.That(result?.IsApproved, Is.True);
        }

        [Test]
        public async Task IsBusinessApprovedAsync_ReturnsTrue_IfBusinessApproved()
        {
            var businessId = Business.Id;

            var result = await _businessService.IsBusinessApprovedAsync(businessId.ToString());

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task IsBusinessApprovedAsync_ReturnsFalse_IfBusinessNotApproved()
        {
            Business businessToApprove = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = true,
                IsApproved = false,
            };
            _data.Businesses.Add(businessToApprove);
            _data.SaveChanges();

            var businessId = businessToApprove.Id;

            var result = await _businessService.IsBusinessApprovedAsync(businessId.ToString());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task ReinstateBusinessAsync_MakesBusinessActive_WithValidId()
        {
            _data = DatabaseMock.Instance;
            SeedDatabase();
            _businessService = new BusinessService(_data);

            Business businessToReinstate = new Business
            {
                Id = new Guid(),
                Title = "Test",
                Description = "Test",
                Address = "Test",
                PrefectureId = 1,
                CategoryId = 1,
                ImageUrl = "https://www.test.com/",
                PhoneNumber = "12-3456-7890",
                IsActive = false,
                IsApproved = true,
            };
            _data.Businesses.Add(businessToReinstate);
            _data.SaveChanges();

            var businessId = businessToReinstate.Id;

            await _businessService.ReinstateBusinessAsync(businessId.ToString());

            var result = await _data.Businesses.FindAsync(businessId);

            Assert.That(result?.IsActive, Is.True);
        }
    }
}
