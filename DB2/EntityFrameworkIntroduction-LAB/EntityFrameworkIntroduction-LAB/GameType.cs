using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class GameType
    {
        public GameType()
        {
            Games = new HashSet<Game>();
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public int? BonusStatsId { get; set; }

        [ForeignKey(nameof(BonusStatsId))]
        [InverseProperty(nameof(Statistic.GameTypes))]
        public virtual Statistic? BonusStats { get; set; }
        [InverseProperty(nameof(Game.GameType))]
        public virtual ICollection<Game> Games { get; set; }

        [ForeignKey("GameTypeId")]
        [InverseProperty(nameof(Item.GameTypes))]
        public virtual ICollection<Item> Items { get; set; }
    }
}
