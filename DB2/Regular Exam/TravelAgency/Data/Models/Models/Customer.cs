using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TravelAgency.Data.DataConstrains;

namespace TravelAgency.Data.Models.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CustomerFullNameMax)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(CustomerEmailMax)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(CustomerPhoneNumberMax)]
        public string PhoneNumber  { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();

    }
}
