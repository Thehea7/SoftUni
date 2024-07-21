using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

       
        public int HomeTeamId { get; set; }
        [ForeignKey(nameof(HomeTeamId))] 
        public Team HomeTeam { get; set; } = null!;

        
        public int AwayTeamId { get; set; }
        [ForeignKey(nameof(AwayTeamId))] 
        public Team AwayTeam { get; set; } = null!;

        
        public int HomeTeamGoals { get; set; }
        
        public int AwayTeamGoals { get; set; }

        public decimal HomeTeamBetRate { get; set; }

        public decimal AwayTeamBetRate { get;set; }

        public decimal DrawBetRate { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [MaxLength(50)] public string Result { get; set; } = null!;

        public virtual ICollection<Bet> Bets { get; set; } = new List<Bet>();
        public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; } = new List<PlayerStatistic>();


    }
}
