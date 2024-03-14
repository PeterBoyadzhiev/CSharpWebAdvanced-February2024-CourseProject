﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ExploreUmami.Common.ValidationConstants.BusinessOwner;

namespace ExploreUmami.Data.Models
{
    public class BusinessOwner
    {

        public BusinessOwner()
        {
            OwnedBusinesses = new HashSet<Business>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        [RegularExpression(PhoneNumberRegularExpression)]
        public string PhoneNumber { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        public ICollection<Business> OwnedBusinesses { get; set; } = null!;
    }
}