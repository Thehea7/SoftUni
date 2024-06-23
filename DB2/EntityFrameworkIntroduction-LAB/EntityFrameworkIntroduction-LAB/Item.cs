using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Item
    {
        public Item()
        {
            GameTypes = new HashSet<GameType>();
            UserGames = new HashSet<UsersGame>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        public int ItemTypeId { get; set; }
        public int StatisticId { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int MinLevel { get; set; }

        [ForeignKey(nameof(ItemTypeId))]
        [InverseProperty("Items")]
        public virtual ItemType ItemType { get; set; } = null!;
        [ForeignKey(nameof(StatisticId))]
        [InverseProperty("Items")]
        public virtual Statistic Statistic { get; set; } = null!;

        [ForeignKey("ItemId")]
        [InverseProperty(nameof(GameType.Items))]
        public virtual ICollection<GameType> GameTypes { get; set; }
        [ForeignKey("ItemId")]
        [InverseProperty(nameof(UsersGame.Items))]
        public virtual ICollection<UsersGame> UserGames { get; set; }
    }
}
