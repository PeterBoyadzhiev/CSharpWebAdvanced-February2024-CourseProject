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
            builder.HasData(GenerateUsers());
        }

        private ApplicationUser[] GenerateUsers()
        {
            ICollection<ApplicationUser> applicationUsers = new HashSet<ApplicationUser>();

            var hasher = new PasswordHasher<ApplicationUser>();
            byte[] randomBytes = RandomNumberGenerator.GetBytes(16); // Generate 16 bytes
            string securityStamp = BitConverter.ToString(randomBytes).Replace("-", "");

            ApplicationUser applicationUser;

            applicationUser = new ApplicationUser
            {
                Id = Guid.Parse("B43C3753-DE4E-4417-B2AD-1C029C7B9795"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM"

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
                Id = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
                UserName = "reviewer@gmail.com",
                NormalizedUserName = "REVIEWER@GMAIL.COM",
                Email = "reviewer@gmail.com",
                NormalizedEmail = "REVIEWER@GMAIL.COM"

            };

            applicationUser.PasswordHash = hasher.HashPassword(applicationUser, "123456");
            applicationUser.SecurityStamp = securityStamp;
            applicationUsers.Add(applicationUser);

            return applicationUsers.ToArray();
        }
    }  
}
