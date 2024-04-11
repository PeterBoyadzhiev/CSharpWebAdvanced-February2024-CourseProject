using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.Category;

namespace ExploreUmami.Web.ViewModels.Category
{
    public class AddCategoryFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = null!;
    }
}
