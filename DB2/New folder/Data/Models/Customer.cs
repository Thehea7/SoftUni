using System.ComponentModel.DataAnnotations;
using TravelAgency.Common;

namespace TravelAgency.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.NameMaxLength)]
        public string FullName { get; set; } = default!;

        [Required]
        [EmailAddress]
        [MaxLength(ValidationConstants.CustomerEmailMaxLength)]
        public string Email { get; set; } = default!;

        [Required]
        [RegularExpression(ValidationConstants.CustomerPhoneNumberPattern)]
        public string PhoneNumber { get; set; } = default!;

        public virtual ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
    }
}
