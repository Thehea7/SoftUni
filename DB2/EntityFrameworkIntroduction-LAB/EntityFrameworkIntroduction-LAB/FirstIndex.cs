using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    [Keyless]
    [Table("FirstIndex")]
    [Index(nameof(City), Name = "IX_FirstIndex_City")]
    [Index(nameof(FirstName), Name = "IX_FirstIndex_FirstName")]
    [Index(nameof(FirstName), nameof(City), Name = "IX_FirstIndex_FirstName_City")]
    [Index(nameof(FirstName), nameof(LastName), Name = "IX_FirstIndex_FirstName_LastName")]
    [Index(nameof(Id), Name = "IX_FirstIndex_ID")]
    [Index(nameof(Id), nameof(City), Name = "IX_FirstIndex_ID_City")]
    [Index(nameof(Id), nameof(FirstName), Name = "IX_FirstIndex_ID_FirstName")]
    [Index(nameof(Id), nameof(LastName), Name = "IX_FirstIndex_ID_LastName")]
    [Index(nameof(LastName), Name = "IX_FirstIndex_LastName")]
    [Index(nameof(LastName), nameof(City), Name = "IX_FirstIndex_LastName_City")]
    public partial class FirstIndex
    {
        [Column("ID")]
        public int? Id { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? City { get; set; }
    }
}
