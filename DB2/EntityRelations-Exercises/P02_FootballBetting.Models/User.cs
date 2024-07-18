using System.ComponentModel.DataAnnotations;
using P02_FootballBetting.Common;

namespace P02_FootballBetting.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.UsernameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.UserNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.UserPassMaxLength)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.UserEmailLength)]
        public string Email { get; set; } = null!;

        [Required]
        public decimal Balance { get; set; }


    }
}
