using System.ComponentModel.DataAnnotations;
using TravelAgency.Common;
using TravelAgency.Data.Models.Enums;

namespace TravelAgency.Data.Models
{
    public class Guide
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.NameMaxLength)]
        public string FullName { get; set; } = default!;

        [Required]
        public Language Language { get; set; }

        public ICollection<TourPackageGuide> TourPackagesGuides { get; set; } = new HashSet<TourPackageGuide>();
    }
}
