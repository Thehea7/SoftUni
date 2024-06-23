using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Currency
    {
        public Currency()
        {
            Countries = new HashSet<Country>();
        }

        [Key]
        [StringLength(3)]
        [Unicode(false)]
        public string CurrencyCode { get; set; } = null!;
        [StringLength(200)]
        public string Description { get; set; } = null!;

        [InverseProperty(nameof(Country.CurrencyCodeNavigation))]
        public virtual ICollection<Country> Countries { get; set; }
    }
}
