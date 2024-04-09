using ExploreUmami.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Data.Configurations
{
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(u => u.FirstName)
                .HasDefaultValue("John");

            builder
                .Property(u => u.LastName)
                .HasDefaultValue("Doe");

            builder.HasData(GenerateUsers());
        }

        private ApplicationUser[] GenerateUsers()
        {
            ICollection<ApplicationUser> applicationUsers = new HashSet<ApplicationUser>();

            var hasher = new PasswordHasher<ApplicationUser>();
            byte[] randomBytes = RandomNumberGenerator.GetBytes(16); //TODO take this out in a method and generate different security stamp for each user
            string securityStamp = BitConverter.ToString(randomBytes).Replace("-", "");

            ApplicationUser applicationUser;

            applicationUser = new ApplicationUser
            {
                Id = Guid.Parse("DED2ED0C-9D4F-4D1D-9BE1-A0B183548BFC"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Admin",
                LastName = "Adminson"

            };

            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            applicationUser.SecurityStamp = securityStamp;

            applicationUsers.Add(applicationUser);

            applicationUser = new ApplicationUser
            {
                Id = Guid.Parse("1AE80037-F648-442E-A309-4B94A3D1315C"),
                UserName = "businessowner@gmail.com",
                NormalizedUserName = "BUSINESSOWNER@GMAIL.COM",
                Email = "businessowner@gmail.com",
                NormalizedEmail = "BUSINESSOWNER@GMAIL.COM"
            };

            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            applicationUser.SecurityStamp = securityStamp;

            applicationUsers.Add(applicationUser);

            applicationUser = new ApplicationUser
            {
                Id = Guid.Parse("B43C3753-DE4E-4417-B2AD-1C029C7B9795"),
                UserName = "businessowner2@gmail.com",
                NormalizedUserName = "BUSINESSOWNER2@GMAIL.COM",
                Email = "businessowner2@gmail.com",
                NormalizedEmail = "BUSINESSOWNER2@GMAIL.COM",
                FirstName = "Jane",
                LastName = "Doe"

            };

            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            applicationUser.SecurityStamp = securityStamp;
            applicationUsers.Add(applicationUser);

            applicationUser = new ApplicationUser
            {
                Id = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
                UserName = "reviewer@gmail.com",
                NormalizedUserName = "REVIEWER@GMAIL.COM",
                Email = "reviewer@gmail.com",
                NormalizedEmail = "REVIEWER@GMAIL.COM",
                FirstName = "Jovani",
                LastName = "Dawson"

            };

            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            applicationUser.SecurityStamp = securityStamp;
            applicationUsers.Add(applicationUser);

            applicationUser = new ApplicationUser
            {
                Id = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"),
                UserName = "reviewer2@gmail.com",
                NormalizedUserName = "REVIEWER2@GMAIL.COM",
                Email = "reviewer2@gmail.com",
                NormalizedEmail = "REVIEWER2@GMAIL.COM",
                FirstName = "Janette",
                LastName = "Dane"
            };

            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            applicationUser.SecurityStamp = securityStamp;
            applicationUsers.Add(applicationUser);

            return applicationUsers.ToArray();
        }
    }  
}
