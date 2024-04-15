using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class BusinessServiceTests : UnitTestsBase
    {
        private IBusinessService _businessService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _data.Database.EnsureCreated();
            _businessService = new BusinessService(_data);
        }
    }
}
