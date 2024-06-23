using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    [Index(nameof(Email), Name = "UQ__People__A9D1053487F9553D", IsUnique = true)]
    public partial class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }
    }
}
