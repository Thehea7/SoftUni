using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        public int GameId { get; set; }
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;
        public int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))] 
        public Player Player { get; set; } = null!;

        [Required] 
        public int ScoredGoals { get; set; } = 0;

        [Required]
        public int Assists { get; set; } = 0;
        [Required]
        public int MinutesPlayed { get; set; } = 0;
    }
}
