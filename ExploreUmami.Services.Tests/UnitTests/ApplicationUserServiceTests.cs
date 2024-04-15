using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data;
using ExploreUmami.Web.ViewModels.User;


namespace ExploreUmami.Services.Tests.UnitTests
{
    public class ApplicationUserServiceTests : UnitTestsBase
    {
        private IApplicationUserService _applicationUserService;

        [SetUp]
        public void SetUp()
        {
            _applicationUserService = new ApplicationUserService(_data);
        }

        [Test]
        public async Task GetUserFullNameByEmailAsync_WithValidEmail_ShouldReturnFullName()
        {
            var userEmail = User.Email;
            var expectedFullName = $"{User.FirstName} {User.LastName}";

            var actualFullName = await _applicationUserService.GetUserFullNameByEmailAsync(userEmail);

            Assert.That(actualFullName, Is.EqualTo(expectedFullName));
        }

        [Test]
        public async Task GetUserFullNameByEmailAsync_WithInvalidEmail_ShouldReturnEmptyString()
        {
            var userEmail = "test@gmailtest.test";
            
            var actualFullName = await _applicationUserService.GetUserFullNameByEmailAsync(userEmail);

            Assert.That(actualFullName, Is.Empty);
        }
    }
}
