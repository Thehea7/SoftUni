using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models.Models
{
    public class TourPackageGuide
    {

        public int	TourPackageId { get; set; }
        [ForeignKey(nameof(TourPackageId))]
        public virtual TourPackage TourPackage { get; set; } = null!;

        public int GuideId { get; set; }
        [ForeignKey(nameof(GuideId))]
        public virtual Guide Guide { get; set; } = null!;

    }
}
