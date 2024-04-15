using ExploreUmami.Data.Models;
using ExploreUmami.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ExploreUmami.Data.Configurations
{
    [ExcludeFromCodeCoverage]
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
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(GenerateReservations());
        }

        private Reservation[] GenerateReservations()
        {
            ICollection<Reservation> reservations = new HashSet<Reservation>();

            Reservation reservation;

            reservation = new Reservation
            {
                Id = Guid.Parse("CCBF170D-F0A7-4DBF-8BDF-6F101548F833"),
                Status = ReservationStatus.Completed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("266A74BB-E01C-4BFC-86A6-D5AAEE18574F"),
                Status = ReservationStatus.Completed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"),
                Notes = "Please reserve a table for a family of 3 adults and 2 children",
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("D3D3D3D3-3D3D-3D3D-3D3D-3D3D3D3D3D3D"),
                Status = ReservationStatus.Completed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("8F87F835-3DEB-43B4-AA01-852C5D287984"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
                Notes = "Please reserve a table for 4 adults",
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("CD6698F0-7D34-4B6C-B9D2-76B1335AF34F"),
                Status = ReservationStatus.Pending,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("7C8605E4-9E6C-474F-8C3C-A837D631C8D4"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"),
                Notes = "Reserve 4 tables, we are a big company",
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("11154B62-2ABD-404A-827E-F4E69AD94678"),
                Status = ReservationStatus.Confirmed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("4222168E-C018-418E-812F-F8D41B322522"),
                UserId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83"),
                Notes = "I'll be visiting with my grandma.",
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("BB49A06D-FBD1-4FDD-A7D4-D309445C59F8"),
                Status = ReservationStatus.Completed,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("4222168E-C018-418E-812F-F8D41B322522"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"),
                Notes = "Looking for delicious pastries",
            };

            reservations.Add(reservation);

            reservation = new Reservation
            {
                Id = Guid.Parse("2F014787-C27C-4406-9B55-4DBCEF08EEFF"),
                Status = ReservationStatus.Cancelled,
                ReservationDate = DateTime.UtcNow,
                BusinessId = Guid.Parse("E39D9DC4-519F-4C74-9F59-86083DF887C6"),
                UserId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846"),
                Notes = "I won't be able to make it, sorry!",
            };

            reservations.Add(reservation);

            return reservations.ToArray();
        }
    }
}
