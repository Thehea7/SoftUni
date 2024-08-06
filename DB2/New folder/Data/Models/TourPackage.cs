using System.ComponentModel.DataAnnotations;
using TravelAgency.Common;

namespace TravelAgency.Data.Models
{
    public class TourPackage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.PackageNameMaxLength)]
        public string PackageName { get; set; } = default!;

        [MaxLength(ValidationConstants.DescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();

        public virtual ICollection<TourPackageGuide> TourPackagesGuides { get; set; } = new HashSet<TourPackageGuide>();
    }
}
