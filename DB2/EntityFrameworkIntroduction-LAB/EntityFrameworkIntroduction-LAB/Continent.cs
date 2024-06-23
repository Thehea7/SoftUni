using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Continent
    {
        public Continent()
        {
            Countries = new HashSet<Country>();
        }

        [Key]
        [StringLength(2)]
        [Unicode(false)]
        public string ContinentCode { get; set; } = null!;
        [StringLength(50)]
        public string ContinentName { get; set; } = null!;

        [InverseProperty(nameof(Country.ContinentCodeNavigation))]
        public virtual ICollection<Country> Countries { get; set; }
    }
}
