using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P02_FootballBetting.Common;

namespace P02_FootballBetting.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.TeamNameMaxlength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.TeamLogoUrlMaxlength)]
        public string LogoUrl { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.TeamInitialsMaxlength)]
        public string Initials { get; set; } = null!;

        [Required]
        public decimal Budget { get; set; }

        [Required]
        public int PrimaryKitColorId { get; set; }

        [ForeignKey(nameof(PrimaryKitColorId))]
        public virtual Color PrimaryColor { get; set; } = null!;
        public int SecondaryKitColorId { get; set; }

        [ForeignKey(nameof(SecondaryKitColorId))]
        public virtual Color SecondaryColor { get; set; } = null!;



    }
}
