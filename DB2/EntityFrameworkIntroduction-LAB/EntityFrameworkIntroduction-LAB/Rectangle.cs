using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Rectangle
    {
        [Key]
        public int Id { get; set; }
        public double A { get; set; }
        public double B { get; set; }
    }
}
