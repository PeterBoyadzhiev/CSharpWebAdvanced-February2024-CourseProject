using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExploreUmami.Data.Configurations
{
    public class EntityConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder
                .HasOne(b => b.Category)
                .WithMany(c => c.Businesses)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(b => b.BusinessOwner)
                .WithMany(bo => bo.OwnedBusinesses)
                .HasForeignKey(b => b.BusinessOwnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
