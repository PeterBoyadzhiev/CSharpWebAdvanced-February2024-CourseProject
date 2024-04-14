using ExploreUmami.Data;
using ExploreUmami.Data.Models;

namespace ExploreUmami.Services.Tests
{
    public static class DatabaseSeeder
    {
        private static ApplicationUser user;
        private static ApplicationUser businessOwnerUser;
        private static BusinessOwner businessOwner;

        public static void SeedDatabase(ExploreUmamiDbContext dbContext)
        {
            businessOwnerUser = new ApplicationUser
            {
                Id = Guid.Parse("1AE80037-F648-442E-A309-4B94A3D1315C"),
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


            user = new ApplicationUser
            {
                Id = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
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

            businessOwner = new BusinessOwner
            {
                Id = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0"),
                FirstName = "John",
                LastName = "Doe",
                NameOfBusiness = "John's Restaurant",
                PhoneNumber = "12-3456-7890",
                UserId = Guid.Parse("1AE80037-F648-442E-A309-4B94A3D1315C")
            };

            dbContext.Users.Add(user);
            dbContext.Users.Add(businessOwnerUser);
            dbContext.BusinessOwners.Add(businessOwner);

            dbContext.SaveChanges();
        }

    }
}
