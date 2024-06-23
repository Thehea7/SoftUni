using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class User
    {
        public User()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; } = null!;
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(15)]
        public string IpAddress { get; set; } = null!;

        [InverseProperty(nameof(UsersGame.User))]
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
