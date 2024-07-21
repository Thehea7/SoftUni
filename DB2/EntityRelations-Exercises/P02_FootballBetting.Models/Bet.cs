using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class Bet
    {
      

        [Key]
        public int BetId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string Prediction { get; set; } = null!;

        [Required] 
        public DateTime DateTime { get; set; } = DateTime.Now;

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))] 
        public User User { get; set; } = null!;

        [Required]

        public int GameId { get; set; }

        [ForeignKey(nameof(GameId))] 
        public Game Game { get; set; } = null!;

    }
}
