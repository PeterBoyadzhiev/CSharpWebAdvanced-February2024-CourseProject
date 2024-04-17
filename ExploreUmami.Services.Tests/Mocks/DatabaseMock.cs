using ExploreUmami.Data;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Tests.Mocks
{
    public class DatabaseMock
    {
        public static ExploreUmamiDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<ExploreUmamiDbContext>()
                    .UseInMemoryDatabase("ExploreUmamiInMemory" + Guid.NewGuid().ToString())
                    .Options;

                return new ExploreUmamiDbContext(dbContextOptions);
            }
        }
    }
}
