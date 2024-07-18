using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P02_FootballBetting.Common;

namespace P02_FootballBetting.Models
{
    public class Color
    {


        [Key]
        public int ColorId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.ColorNameMaxlength)]

        public string Name { get; set; } = null!;

        public ICollection<Team> PrimaryKitTeams { get; set; } = new List<Team>();
        public ICollection<Team> SecondaryKitTeams { get; set; } = new List<Team>();


    }
}
