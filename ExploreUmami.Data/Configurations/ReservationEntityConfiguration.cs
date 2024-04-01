﻿using ExploreUmami.Data.Models;
using ExploreUmami.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExploreUmami.Data.Configurations
{
    public class ReservationEntityConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder
                .Property(r => r.Status)
                .HasConversion<string>()
                .HasDefaultValue(ReservationStatus.Pending);

            builder
                .HasOne(r => r.Business)
                .WithMany(b => b.Reservations)
                .HasForeignKey(r => r.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                .HasOne(r => r.UserVisit)
                .WithOne(uv => uv.Reservation)
                .HasForeignKey<Reservation>(r => r.UserVisitId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateReservations());
        }

        private Reservation[] GenerateReservations()
        {
            ICollection<Reservation> reservations = new HashSet<Reservation>();

            Reservation reservation;

            reservation = new Reservation
            {
                Id = Guid.Parse("CCBF170D-F0A7-4DBF-8BDF-6F101548F833"),
                Status = ReservationStatus.Pending,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
                UserVisitId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C85")
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("266A74BB-E01C-4BFC-86A6-D5AAEE18574F"),
                Status = ReservationStatus.Confirmed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"),
                UserVisitId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1847")
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("D3D3D3D3-3D3D-3D3D-3D3D-3D3D3D3D3D3D"),
                Status = ReservationStatus.Completed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("8F87F835-3DEB-43B4-AA01-852C5D287984"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
                UserVisitId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C84")
            };

            reservations.Add(reservation);

            return reservations.ToArray();
        }
    }
}
