using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Mountain
    {
        public Mountain()
        {
            Peaks = new HashSet<Peak>();
            CountryCodes = new HashSet<Country>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string MountainRange { get; set; } = null!;

        [InverseProperty(nameof(Peak.Mountain))]
        public virtual ICollection<Peak> Peaks { get; set; }

        [ForeignKey("MountainId")]
        [InverseProperty(nameof(Country.Mountains))]
        public virtual ICollection<Country> CountryCodes { get; set; }
    }
}
