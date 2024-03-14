using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.Category;

namespace ExploreUmami.Data.Models
{
    public class Category
    {
        public Category()
        {
            Businesses = new HashSet<Business>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();

    }
}
