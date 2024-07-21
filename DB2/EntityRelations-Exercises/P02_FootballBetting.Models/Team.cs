using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P02_FootballBetting.Common;

namespace P02_FootballBetting.Data.Models
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

        // Relations to Color


        public int PrimaryKitColorId { get; set; }

        [ForeignKey(nameof(PrimaryKitColorId))]
        public virtual Color PrimaryKitColor { get; set; } = null!;


        public int SecondaryKitColorId { get; set; }

        [ForeignKey(nameof(SecondaryKitColorId))]
        public virtual Color SecondaryKitColor { get; set; } = null!;

        // Relation to Town
        [Required]
        public int TownId { get; set; }

        [ForeignKey(nameof(TownId))]

        public virtual Town Town { get; set; } = null!;

        //Relation to Players

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();

        //relation to Games
        [InverseProperty("HomeTeam")]
        public virtual ICollection<Game> HomeGames { get; set; } = new List<Game>();

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Game> AwayGames { get; set; } = new List<Game>();

    }
}
