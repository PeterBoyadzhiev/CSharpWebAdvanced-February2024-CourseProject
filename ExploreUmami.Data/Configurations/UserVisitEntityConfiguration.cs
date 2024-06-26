﻿using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ExploreUmami.Data.Configurations
{
    [ExcludeFromCodeCoverage]
    public class UserVisitEntityConfiguration : IEntityTypeConfiguration<UserVisit>
    {
        public void Configure(EntityTypeBuilder<UserVisit> builder)
        {
            builder
                .Property(b => b.VisitDate)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasOne(uv => uv.Business)
                .WithMany(b => b.UserVisits)
                .HasForeignKey(uv => uv.BusinessId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(uv => uv.User)
                .WithMany(u => u.UserVisits)
                .HasForeignKey(uv => uv.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(GenerateUserVisits());
        }

        private UserVisit[] GenerateUserVisits()
        {
            ICollection<UserVisit> userVisits = new HashSet<UserVisit>();

            UserVisit userVisit;

            userVisit = new UserVisit
            {
                Id = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C85"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"), // reviewer
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"), // Restaurant
                ReservationId = Guid.Parse("CCBF170D-F0A7-4DBF-8BDF-6F101548F833")
            };

            userVisits.Add(userVisit);

            userVisit = new UserVisit
            {
                Id = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1847"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"), //reviewer2
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"), // Restaurant
                ReservationId = Guid.Parse("266A74BB-E01C-4BFC-86A6-D5AAEE18574F")
            };

            userVisits.Add(userVisit);

            userVisit = new UserVisit
            {
                Id = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C84"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"), //reviewer2
                BusinessId = Guid.Parse("8F87F835-3DEB-43B4-AA01-852C5D287984"), // Cafe
                ReservationId = Guid.Parse("D3D3D3D3-3D3D-3D3D-3D3D-3D3D3D3D3D3D")
            };

            userVisits.Add(userVisit);

            userVisit = new UserVisit
            {
                Id = Guid.Parse("4F8E6201-2013-428A-8DDB-C75312CA9BFF"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"), //reviewer2
                BusinessId = Guid.Parse("4222168E-C018-418E-812F-F8D41B322522"), // Cafe
                ReservationId = Guid.Parse("BB49A06D-FBD1-4FDD-A7D4-D309445C59F8")
            };

            userVisits.Add(userVisit);

            return userVisits.ToArray();
        }
    }
}
