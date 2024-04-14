namespace ExploreUmami.Services.Tests
{
    using ExploreUmami.Data;
    using ExploreUmami.Services.Data;
    using ExploreUmami.Services.Data.Interfaces;

    using Microsoft.EntityFrameworkCore;

    using static DatabaseSeeder;

    public class BusinessOwnerServiceTests
    {

        private DbContextOptions<ExploreUmamiDbContext> dbOptions;
        private ExploreUmamiDbContext dbContext;

        private IBusinessOwnerService businessOwnerService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            dbOptions = new DbContextOptionsBuilder<ExploreUmamiDbContext>()
                .UseInMemoryDatabase(databaseName: "ExploreUmamiTest")
                .Options;
            dbContext = new ExploreUmamiDbContext(dbOptions);

            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);

            this.businessOwnerService = new BusinessOwnerService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}