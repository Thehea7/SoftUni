using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    [Keyless]
    public partial class Minion
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
