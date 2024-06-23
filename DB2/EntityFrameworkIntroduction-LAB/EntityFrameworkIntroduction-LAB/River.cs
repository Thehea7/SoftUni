using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class River
    {
        public River()
        {
            CountryCodes = new HashSet<Country>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string RiverName { get; set; } = null!;
        public int Length { get; set; }
        public int DrainageArea { get; set; }
        public int AverageDischarge { get; set; }
        [StringLength(50)]
        public string Outflow { get; set; } = null!;

        [ForeignKey("RiverId")]
        [InverseProperty(nameof(Country.Rivers))]
        public virtual ICollection<Country> CountryCodes { get; set; }
    }
}
