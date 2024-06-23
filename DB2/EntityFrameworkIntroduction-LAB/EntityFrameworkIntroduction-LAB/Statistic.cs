using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Statistic
    {
        public Statistic()
        {
            Characters = new HashSet<Character>();
            GameTypes = new HashSet<GameType>();
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Mind { get; set; }
        public int Speed { get; set; }
        public int Luck { get; set; }

        [InverseProperty(nameof(Character.Statistic))]
        public virtual ICollection<Character> Characters { get; set; }
        [InverseProperty(nameof(GameType.BonusStats))]
        public virtual ICollection<GameType> GameTypes { get; set; }
        [InverseProperty(nameof(Item.Statistic))]
        public virtual ICollection<Item> Items { get; set; }
    }
}
