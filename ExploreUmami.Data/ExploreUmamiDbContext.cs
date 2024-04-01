using ExploreUmami.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExploreUmami.Data
{
    public class ExploreUmamiDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ExploreUmamiDbContext(DbContextOptions<ExploreUmamiDbContext> options)
            : base(options)
        {

        }

        public DbSet<Business> Businesses { get; set; } = null!;

        public DbSet<BusinessOwner> BusinessOwners { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<Prefecture> Prefectures { get; set; } = null!;

        public DbSet<UserVisit> UserVisits { get; set; } = null!;

        public DbSet<Reservation> Reservations { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(ExploreUmamiDbContext)) ?? Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }

    }
}
