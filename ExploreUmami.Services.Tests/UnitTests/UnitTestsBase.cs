using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Tests.Mocks;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected ExploreUmamiDbContext _data;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            _data = DatabaseMock.Instance;

            SeedDatabase();
        }

        public ApplicationUser User { get; private set; }
        public ApplicationUser User2 { get; private set; }
        public ApplicationUser BusinessOwnerUser { get; private set; }
        public BusinessOwner BusinessOwner { get; private set; }

        public void SeedDatabase()
        {
            BusinessOwnerUser = new ApplicationUser
            {
                Id = Guid.Parse("330734B1-7BC6-43C7-8D38-FFD1A8C952C8"),
                UserName = "businessowner@gmail.com",
                NormalizedUserName = "BUSINESSOWNER@GMAIL.COM",
                Email = "businessowner@gmail.com",
                NormalizedEmail = "BUSINESSOWNER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                ConcurrencyStamp = "cc72b139-43ab-4ae5-b038-79fa73cd776f",
                SecurityStamp = "ddd00f02-8d99-4e8f-a93e-bd2d8faa6d1e",
                TwoFactorEnabled = false,
                FirstName = "Jon",
                LastName = "Doe"
            };

            _data.Users.Add(BusinessOwnerUser);

            User = new ApplicationUser
            {
                Id = Guid.Parse("5807486E-94BF-41E4-891B-9D85916AE93B"),
                UserName = "reviewer@gmail.com",
                NormalizedUserName = "REVIEWER@GMAIL.COM",
                Email = "reviewer@gmail.com",
                NormalizedEmail = "REVIEWER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                ConcurrencyStamp = "51b04ee6-f5e8-4b08-aae6-e1b9f9872928",
                SecurityStamp = "66cb0731-2c57-4a02-b610-6eced0bc5623",
                TwoFactorEnabled = false,
                FirstName = "Jovani",
                LastName = "Dawson",
            };

            _data.Users.Add(User);

            User2 = new ApplicationUser
            {
                Id = Guid.Parse("FB3DE047-2B22-4EE8-A038-85DC5EE1BDD2"),
                UserName = "reviewer2@gmail.com",
                NormalizedUserName = "REVIEWER2@GMAIL.COM",
                Email = "reviewer2@gmail.com",
                NormalizedEmail = "REVIEWER2@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                ConcurrencyStamp = "1afa0e2f-2881-41e2-b9f1-35adf1d36742",
                SecurityStamp = "7048d2b3-a33f-4a42-9c9f-1ecb1369cd0a",
                TwoFactorEnabled = false,
                FirstName = "Janette",
                LastName = "Davinci",
            };

            _data.Users.Add(User2);

            BusinessOwner = new BusinessOwner
            {
                FirstName = "John",
                LastName = "Doe",
                NameOfBusiness = "John's Restaurant",
                PhoneNumber = "12-3456-7890",
                UserId = Guid.Parse("330734B1-7BC6-43C7-8D38-FFD1A8C952C8")
            };

            _data.BusinessOwners.Add(BusinessOwner);

            _data.SaveChanges();
        }

        [OneTimeTearDown]
        public void TearDownBase()
        {
            _data.Dispose();
        }
    }
}
