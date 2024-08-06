using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data.Models.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        
        public DateTime BookingDate { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; } = null!;

        [Required]
        public int TourPackageId { get; set; }
        [ForeignKey(nameof(TourPackageId))]
        public virtual TourPackage TourPackage { get; set; } = null!;

        
    }
}
