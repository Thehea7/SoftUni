using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TravelAgency.Data.DataConstrains;

namespace TravelAgency.Data.Models.Models
{
    public class TourPackage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(PackageNameMax)]
        public string PackageName { get; set; } = null!;

        [MaxLength(PackageDescriptionMax)]
        public string? 	Description { get; set; }

        public decimal  Price { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();

        public virtual ICollection<TourPackageGuide> TourPackagesGuides { get; set; } = new HashSet<TourPackageGuide>();

        
    }
}
