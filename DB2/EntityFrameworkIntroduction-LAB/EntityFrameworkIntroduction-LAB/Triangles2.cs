using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    [Keyless]
    [Table("Triangles2")]
    public partial class Triangles2
    {
        public int Id { get; set; }
        public double A { get; set; }
        public double H { get; set; }
    }
}
