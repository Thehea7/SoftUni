using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class UsersGame
    {
        public UsersGame()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int CharacterId { get; set; }
        public int Level { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime JoinedOn { get; set; }
        [Column(TypeName = "money")]
        public decimal Cash { get; set; }

        [ForeignKey(nameof(CharacterId))]
        [InverseProperty("UsersGames")]
        public virtual Character Character { get; set; } = null!;
        [ForeignKey(nameof(GameId))]
        [InverseProperty("UsersGames")]
        public virtual Game Game { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UsersGames")]
        public virtual User User { get; set; } = null!;

        [ForeignKey("UserGameId")]
        [InverseProperty(nameof(Item.UserGames))]
        public virtual ICollection<Item> Items { get; set; }
    }
}
