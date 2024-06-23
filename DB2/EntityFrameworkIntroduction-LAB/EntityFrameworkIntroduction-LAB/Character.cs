using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Character
    {
        public Character()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public int? StatisticId { get; set; }

        [ForeignKey(nameof(StatisticId))]
        [InverseProperty("Characters")]
        public virtual Statistic? Statistic { get; set; }
        [InverseProperty(nameof(UsersGame.Character))]
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
