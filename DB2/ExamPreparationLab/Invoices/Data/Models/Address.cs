using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Invoices.Data.DataConstraints;

namespace Invoices.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(StreetNameMaxLength)]
        public string StreetName { get; set; } = null!;

        public int StreetNumber  { get; set; }

        [Required] public string PostCode { get; set; } = null!;

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; } = null!;

        [Required] [MaxLength(CountryMaxLength)] public string Country { get; set; } = null!;

        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; } = null!;
    }
}
