using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data.Models.Enums;
using static TravelAgency.Data.DataConstrains;

namespace TravelAgency.Data.Models.Models
{
    public class Guide
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(GuideFullNameMax)]
        public string FullName { get; set; } = null!;

        public Language Language { get; set; }

        public virtual ICollection<TourPackageGuide> TourPackagesGuides { get; set; } = new HashSet<TourPackageGuide>();

    }
}
