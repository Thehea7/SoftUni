using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P02_FootballBetting.Common;

namespace P02_FootballBetting.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.PositionNameMaxlength)]
        public string Name { get; set; } = null!;
    }
}
