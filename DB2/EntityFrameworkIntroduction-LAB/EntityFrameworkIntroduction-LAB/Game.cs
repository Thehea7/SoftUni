using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Game
    {
        public Game()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Start { get; set; }
        public int? Duration { get; set; }
        public int GameTypeId { get; set; }
        public bool IsFinished { get; set; }

        [ForeignKey(nameof(GameTypeId))]
        [InverseProperty("Games")]
        public virtual GameType GameType { get; set; } = null!;
        [InverseProperty(nameof(UsersGame.Game))]
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
