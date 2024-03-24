using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.NetworkInformation;


namespace ExploreUmami.Data.Configurations
{
    public class BusinessOwnerEntityConfiguration : IEntityTypeConfiguration<BusinessOwner>
    {
        public void Configure(EntityTypeBuilder<BusinessOwner> builder)
        {
            builder
                .HasData(GenerateBusinessOwners());
        }

        private BusinessOwner[] GenerateBusinessOwners()
        {
            ICollection<BusinessOwner> businessOwners = new HashSet<BusinessOwner>();

            BusinessOwner businessOwner;

            businessOwner = new BusinessOwner
            {
                Id = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0"),
                FirstName = "John",
                LastName = "Doe",
                NameOfBusiness = "John's Restaurant",
                PhoneNumber = "12-3456-7890",
                UserId = Guid.Parse("B43C3753-DE4E-4417-B2AD-1C029C7B9795")
            };

            businessOwners.Add(businessOwner);

            businessOwner = new BusinessOwner
            {
                Id = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF"),
                FirstName = "Jane",
                LastName = "Doe",
                NameOfBusiness = "Jane's Cafe",
                PhoneNumber = "12-3456-7890",
                UserId = Guid.Parse("1AE80037-F648-442E-A309-4B94A3D1315C")
            };

            businessOwners.Add(businessOwner);

            return businessOwners.ToArray();
        }
    }
}
