using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Country
    {
        public Country()
        {
            Mountains = new HashSet<Mountain>();
            Rivers = new HashSet<River>();
        }

        [Key]
        [StringLength(2)]
        [Unicode(false)]
        public string CountryCode { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string IsoCode { get; set; } = null!;
        [StringLength(45)]
        [Unicode(false)]
        public string CountryName { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string? CurrencyCode { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string ContinentCode { get; set; } = null!;
        public int Population { get; set; }
        public int AreaInSqKm { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Capital { get; set; } = null!;

        [ForeignKey(nameof(ContinentCode))]
        [InverseProperty(nameof(Continent.Countries))]
        public virtual Continent ContinentCodeNavigation { get; set; } = null!;
        [ForeignKey(nameof(CurrencyCode))]
        [InverseProperty(nameof(Currency.Countries))]
        public virtual Currency? CurrencyCodeNavigation { get; set; }

        [ForeignKey("CountryCode")]
        [InverseProperty(nameof(Mountain.CountryCodes))]
        public virtual ICollection<Mountain> Mountains { get; set; }
        [ForeignKey("CountryCode")]
        [InverseProperty(nameof(River.CountryCodes))]
        public virtual ICollection<River> Rivers { get; set; }
    }
}
